using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			// here you use any functions you wanna try
			var list = new PrimeList(100);
			foreach (var value in list)
			{
				Console.WriteLine(value);
			}

			string stop = Console.ReadLine();
		}
	}
}
