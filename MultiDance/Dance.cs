using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MultiDance
{
	/// <summary>
	/// this file is a litteal 
	/// </summary>
	public class SscDance
	{
		public dynamic NoteData;
		public string ChartName;
		
		/// <summary>
		/// Is it dance-single
		/// </summary>
		public string StepsType;

		public string Description;
		public string ChartStyle;
		public string Credit;

		/// <summary>
		/// a measure of difficulty
		/// </summary>
		public int Meter;

		/// <summary>
		/// Another measure of difficulty
		/// </summary>
		public Difficulty Difficulty;


		/// <summary>
		/// who the hell knows? nobody cares. plot it for lols.
		/// </summary>
		public double[] RadarValues;

		/// <summary>
		/// Important
		/// 1 note
		/// 2 start hold
		/// 3 end hold
		/// m is mine
		/// </summary>
		public string[] Notes;

		public static SscDance Parse(Dictionary<string,string> data)
		{
			var dance = new SscDance();
			ParseUtils.SuperParse(dance, data);
			return dance;
		}

		int NumPads = 4;
		//const double NotesPerMeasure = 4;

		public IEnumerable<Note> GetNotes()
		{
			var curretHolds = new Note[NumPads];

			for (int measure = 0; measure < Notes.Length; measure++)
			{
				var lines = Notes[measure].Split('\n').Select(x => x.Trim().ToUpperInvariant().ToCharArray()).Where(x=>x.Length==NumPads).ToArray();


				for (int noteIndex = 0; noteIndex < lines.Length; noteIndex++)
				{
					var beatTime = (measure + (double)noteIndex / lines.Length);

					var line = lines[noteIndex];
					for (int pad = 0; pad <NumPads; pad++)
					{
						
						switch (line[pad])
						{
							case '1':
								yield return new Note
								{
									arrow = (Arrow)pad,
									start = beatTime,
									type = NoteType.Tap,
								};
								break;
							case '2':
								var note = new Note
								{
									arrow = (Arrow)pad,
									start = beatTime,
									type = NoteType.Hold,
								};
								curretHolds[pad] = note;
								yield return note;
								break;
							case '3':
								curretHolds[pad].end = beatTime;
								break;
							case 'M':
								yield return new Note
								{
									arrow = (Arrow)pad,
									start = beatTime,
									type = NoteType.Bomb,
								};
								break;
							default:
								break;
						}
						
 					}
				}

			}
		}

	}
}
