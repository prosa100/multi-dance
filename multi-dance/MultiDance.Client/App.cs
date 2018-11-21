using Bridge;
using MultiDance.Tests;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace MultiDance.Client
{
	public class App
	{
		public static void Main()
		{
			var chart = Chart.Parse(TestData.StepFile);
			var notes = chart.Dances[0].GetNotes().ToArray();
			foreach (var note in notes)
			{
				Console.WriteLine($"new Vector3({(int)note.arrow}, {note.start}f, 0),");
			}
		}
	}
}