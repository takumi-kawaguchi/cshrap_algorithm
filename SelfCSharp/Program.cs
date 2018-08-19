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
			var array = new FreeArray(5);
			array[0] = 1;
			array[1] = 10;
			array[2] = 15;
			array[3] = 30;
			array[4] = 60;

			Console.WriteLine(array[2]);
			Console.WriteLine(array[-10]);
			Console.WriteLine(array[6]);

			string stop = Console.ReadLine();
		}
	}
}
