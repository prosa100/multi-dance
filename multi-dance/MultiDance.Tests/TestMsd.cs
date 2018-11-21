using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Xunit;
using static Xunit.Assert;

namespace MultiDance.Tests
{
	public class TestMsd
    {
		[Fact]
		public void TestLoad()
		{
			var msd = Msd.ParseMsd(TestData.StepFile);
			Equal("Goin' Under", msd[0]["TITLE"]);
		}

		[Fact]
		public void TestChart()
		{
			var chart = Chart.Parse(TestData.StepFile);
			Equal("Goin' Under", chart.Title);
			var notes = chart.Dances[0].GetNotes().ToArray();
			foreach (var note in notes)
			{
				Debug.WriteLine(note);
			} 
		}
	}
}
