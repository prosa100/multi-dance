using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDance
{
	class PadPress
	{
		public Arrow arrow;
		public double time;
		public bool press;
	}


	enum MessageTypes
	{
		Ping,
		PushSong,
		Vote,
		Note,

	}
    class SongPlayer
    {
		double offset;
		double screenLag;


		// store hit info client side?

		// idk somethig?
		double score;
		double health;

		public int chainLength;

		Note[] currentNotes;

		Queue<Note> notes;

		/// <summary>
		/// the curret time in beats
		/// </summary>
		public double now;


		TimingWindowJudge judge;
		


		/// <summary>
		/// i am going to assume a 1 sec global 'hot' pass fiter
		/// for possible notes oyu could be peasing
		/// will use this is data for lag predtion model for operation
		/// steamed hams
		/// </summary>
		/// <param name="pow"></param>
		public void OnKeyPress(PadPress pow)
		{
			// freshen up the notes in my dimension.
			var noq = currentNotes[(int)pow.arrow];
			
			var verdict = judge.Judge(noq, now);
			if (verdict == null)
				return;
		}

		public void Score(TimingWindow timing)
		{
			if(timing.LooseChain)
			{
				chainLength = 0;
			}
			else
			{
				chainLength++;
			}

			// apparently this is how it works?
			if(chainLength > 10)
			{
				health += timing.Health;
			}

			score += timing.Score;
		}

		/// <summary>
		/// This needs to be run for ~1000 ccu
		/// which is not really cool becuse this can take up to 1 ms to load.
		/// I expect that we can peak at 2k viewrs, and becuse of the aparent simplicity it is a good thing
		/// as a result, tick only gets called when a note is cool.
		/// handlled in mass on server
		/// cliet updates on draw.
		/// may need to do some timy whimy stuff to handle that
		/// also key press are event based
		/// short coming right now i only look for the best note. suspect i may need to keep a hotbar of a few
		/// want to move this to a playar or something
		/// </summary>
		public void Tick()
		{
			Note note;
			for (int pad = 0; pad < currentNotes.Length; pad++)
			{
				note = currentNotes[pad];

				// take out the trash
				
				if(note!=null && (note.end ?? note.start) - TimingWindowJudge.MaxReleventWinow > now)
				{
					Score(judge.Miss); // yeah you done goof
					currentNotes[pad] = null;
				}
			}
			note = notes.Peek();
			while(note!=null && note.start + TimingWindowJudge.MaxReleventWinow > now)
			{
				if (currentNotes[(int)note.arrow]==null)
				{
					currentNotes[(int)note.arrow] = notes.Dequeue();
				}
			}
		}



		public void Connect()
		{

		}



    }
}
