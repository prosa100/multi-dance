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
		Queue<BpmChangeEvent> events;
		Note[] CurrentNotes;
    }
}
