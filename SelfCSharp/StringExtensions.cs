using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	static class StringExtensions
	{
		public static string Repeat(this string str, int count)
		{
			var builder = new StringBuilder();
			for (var i = 1; i <= count; i++)
			{
				builder.Append(str);
			}
			return builder.ToString();
		}
	}
}
