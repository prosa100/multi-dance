using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace MultiDance
{
    public class Msd : Dictionary<string, string[]>
    {
		/// <summary>
		/// parse an msd file
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static Dictionary<string, string>[] ParseMsd(string input)
		{
			var sections = input.Split(new[] { "//" }, StringSplitOptions.None);

			// split into chucks
			sections = sections.Take(1).Concat(sections.Skip(1).Select(
				s => s.Split(new[] { '\n' }, 2)[1].Trim()
				)).ToArray();

			var data = sections.Select(section =>
				section.Split('#').Select(x=>x.Trim()).Where(x=>x!="").Select(param =>
				{
					var parts = param.Split(':');
					parts[parts.Length - 1] = parts[parts.Length - 1].Split(';')[0];
					return parts.Select(x => x.Trim());
				}).ToDictionary(p => p.First(), p => p.Skip(1).First())).ToArray();

			return data;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		//public static Msd Parse(StringReader input)
		//{
		//	var msd = new Msd();
		//	string key = null;
		//	var values = new List<string>();
		//	string line;

		//	while ((line = input.ReadLine())!=null)
		//	{

		//		if (line == "")
		//			continue;

		//		if (line.StartsWith("//"))
		//			continue;

		//		var isStartOfKV = line.StartsWith("#");
		//		var hasTerminator = line.EndsWith(";");

		//		line = line.Split(';')[0].Trim();


		//		var kv = line.Split(new[] { ':' }, 2);

		//		// missing ';' detected. repairing
		//		if(kv.Length == 2 && key != null)
		//		{
		//			// finalize
		//			msd[key] = values.ToArray();
		//			values.Clear();
		//			key = null;
		//		}

		//		if (key == null)
		//		{
		//			if (kv.Length != 2)
		//				throw new InvalidDataException("Floating key");
		//			key = kv[0].Substring(1).ToUpperInvariant();
		//			line = kv[1].Trim();
		//		}
				
		//		if(line!="")
		//		{
		//			values.Add(line);
		//		}

		//		if (hasTerminator)
		//		{
		//			// finalize
		//			msd[key] = values.ToArray();
		//			values.Clear();
		//			key = null;
		//		}
		//	}

		//	if (key!=null)
		//	{
		//		// finalize
		//		msd[key] = values.ToArray();
		//		values.Clear();
		//		key = null;
		//	}


		//	return msd;
		//	//TODO : supot files that ommit ;
			

		//	//var parts = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
		//	//	.Where(x => !x.StartsWith("#")) //no comments
		//	//	.Select(opt => opt.Split(new[] { ':' }, 2));
		//}
    }
}
