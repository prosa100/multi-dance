using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDance
{
	public static class Polyfills
	{
		public static string ToUpperInvariant(this string self) => self.ToUpper();
	}
}
