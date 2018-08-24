using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfCSharp.Chap08.Polymo;

namespace SelfCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			// here you use any functions you wanna try
			Triangle t = new Triangle(10, 30);
			Console.WriteLine(t.GetArea());
			Square s = new Square(10, 30);
			Console.WriteLine(s.GetArea());

			string stop = Console.ReadLine();
		}
	}
}
