using System;
using System.Text;

namespace MultiDance
{
	class DanceEvent
	{
		/// <summary>
		/// When the change start to occurs
		/// </summary>
		public double BeatNumber;

	}
	class BpmChangeEvent
	{


		/// <summary>
		/// The new beats per minute
		/// </summary>
		public double NewBpm;
	}


	class StopEvent
	{
		public double BeatNumber;

	}
}
