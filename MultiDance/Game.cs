using System.Collections.Generic;

namespace MultiDance
{
	/// <summary>
	/// Start after last note ore 
	/// </summary>
	class Game
    {
		public double BeatNumber;
		public double BeatsPerMinute;
		public double Speed;

		public double StartTime;


		Queue<BpmChangeEvent> events;
		Note[] CurrentNotes;


		public void Run()
		{
			var chart = Chart.Parse(TestData.StepFile);
			var player = new SongPlayer();
			player.Tick();
		}
    }
}
