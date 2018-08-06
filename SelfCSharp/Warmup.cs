using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Warmup
	{
		static public void Euclid()
		{
			Console.WriteLine("二つの数値を入力してください");
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());

			while(num1 != num2)
			{
				if (num1 > num2)
				{
					num1 = num1 - num2;
				} else
				{
					num2 = num2 - num1;
				}
			}
			Console.WriteLine("最大公約数は{0}", num1);
		}

		static public void Euclid2()
		{
			Console.WriteLine("二つの数値を入力して下さい");
			var num1 = int.Parse(Console.ReadLine());
			var num2 = int.Parse(Console.ReadLine());

			int k;
			do
			{
				k = num1 % num2;
				num1 = num2;
				num2 = k;
			} while (k != 0);

			Console.WriteLine("最小公約数は{0}", num1);
		}
	}
}
