using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDance
{

	public static class ParseUtils
	{
		static object Parse(string input, Type type)
		{
			if (type == typeof(object) || type == typeof(string))
				return input;

			if (type.IsArray)
			{
				var vals = input.Split(',').Select(group => Parse(group, type.GetElementType())).ToArray();

				var outArray = Array.CreateInstance(type.GetElementType(), vals.Length);

				//var outArrayType = type.MakeArrayType();
				//var outArray = outArrayType.GetConstructor(new[] { typeof(int) }).Invoke(new object[] { vals.Length });
				for (int i = 0; i < vals.Length; i++)
				{
					outArray.SetValue(vals[i], i);
				}
				return outArray;

			}


			if(type.BaseType == typeof(Enum))
			{
				return Enum.Parse(type, input);
			}


			if (type == typeof(bool))
			{
				input = input.ToUpperInvariant();
				if (input == "YES")
					return true;
				else if (input == "NO")
					return false;
				else
					return bool.Parse(input);
			}

			var parseMethod = type.GetMethod("Parse", new[] { typeof(string) });
			if (parseMethod != null)
			{
				return parseMethod.Invoke(null, new[] { input });
			}

			//var converter = TypeDescriptor.GetConverter(member.FieldType);
			//var parsedValue = converter.ConvertFrom(value);
			//member.SetValue(chart, parsedValue);

			return input;
		}


		public static void SuperParse(object output, Dictionary<string, string> inputs)
		{
			var members = output.GetType().GetFields().ToDictionary(x => x.Name.ToUpperInvariant());

			foreach (var param in inputs)
			{
				var member = members[param.Key];
				var value = param.Value;

				member.SetValue(output, Parse(value, member.FieldType));




			}
		}
	}
}
