using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.ComponentModel;

namespace MultiDance
{
	public class Chart
	{
		public Version Version;
		public string Title;
		public string Subtitle;
		public string Artist;

		public string TITLETRANSLIT, SUBTITLETRANSLIT, ARTISTTRANSLIT;

		public string Genre;
		public string Origin;
		public string Credit;
		public string Banner;

		public string PREVIEWVID, JACKET, CDIMAGE, DiscImage, LYRICSPATH, CDTitle;

		public string Background;
		public string Music;

		public double Offset;
		public double SampleStart;

		public double SampleLength;
		public bool Selectable;

		/// <summary>
		/// #BPMS:0.000=210.000;
		/// </summary>
		/// 
		// events?
		public string Bpms;
		public object Stops;
		public object Delays;
		public object Warps;
		public object TimeSignatures;
		public object TickCounts;
		public object Combos;
		public object Speeds;
		public object Scrolls;
		public object Fakes;
		public object Labels;
		public object BgChanges;
		public object Keysounds;
		public object Attacks;

		public SscDance[] Dances;


		public static Chart Parse(string input)
		{
			Chart chart = new Chart();

			var msd = Msd.ParseMsd(input);

			var mine = msd[0];//.ToDictionary(x=>x.Key,x=>x.Value.First());
			ParseUtils.SuperParse(chart, mine);

			chart.Dances = msd.Skip(1).Select(SscDance.Parse).ToArray();

			return chart;
		}

	}
}
