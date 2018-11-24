using System;

namespace MultiDance
{

	[System.AttributeUsage(System.AttributeTargets.Method)]
	sealed class RpcAttribute : System.Attribute
	{
	}
	class NetClock
	{
		DateTime epoch;
		double offset;

		public double Now {
		get {
				return (DateTime.UtcNow - epoch).TotalSeconds + offset;
			} }


		public static NetClock masterClock;

		public Network network;

		[Rpc]
		public double GetTime()
		{
			return Now;
		}

		/// <summary>
		/// start timer
		/// ask the server what time it is
		/// offset = stime-timer/2
		/// </summary>
		public async void SyncTime()
		{
#if NATIVE
			throw new Exception("Bad time");
#endif
			// this is not the correct way to do this on CIL
			// the time elapsed may be 0
			var start = DateTime.UtcNow;
			epoch = start;
			var serverTime = GetTime();
			var end = DateTime.UtcNow;

			var elapsedTime = (end - start).TotalSeconds;
			offset = serverTime - elapsedTime;
		}
	}
}
