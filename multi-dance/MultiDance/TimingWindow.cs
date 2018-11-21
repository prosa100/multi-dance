using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDance
{
	enum ScoreLevel
	{
		Fantastic, Excellent, Great,

		// breaks combo
		Decent, // 0h, 0p
		WayOff, Miss
	}

	class TimingWindow
	{
		ScoreLevel score;

		[Obsolete]
		public static string Name;

		public double Width;
		public double Score;
		public double Health = 1;
		public bool LooseChain;
	}
    class TimingWindowJudge
    {
		public const double MaxReleventWinow = 1;
		public double Size;
		public TimingWindow[] windows;
		public TimingWindow Miss;

		public TimingWindow Judge(Note note, double start)
		{
			var error = Math.Abs(note.start - start);
			return windows.FirstOrDefault(x => x.Width > error);
		}
    }
}
