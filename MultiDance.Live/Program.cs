using MultiDance.Tests;
using System;
using System.Diagnostics;
using System.Linq;


using System.Net.Http;
using System.Web;

namespace MultiDance.Live
{
    class Program
    {
        static void Main(string[] args)
        {
			var chart = Chart.Parse(TestData.StepFile);
			var notes = chart.Dances[0].GetNotes().ToArray();
			foreach (var note in notes)
			{
				Debug.WriteLine(note);
				Console.WriteLine($"new Vector3({(int)note.arrow}, {note.start}f, 0),");
			}
			Console.ReadLine();
		}
    }
}
