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

		static public void GetPrimeNumber()
		{
			Console.WriteLine("数字を入力してください");
			var num = int.Parse(Console.ReadLine());

			double limit;

			while (true)
			{
				if (num >= 2)
				{
					for (limit = (int)Math.Sqrt(num) ; limit > 1; limit--)
					{
						if (num % limit == 0)
						{
							break;
						}
					}
					if (limit == 1)
					{
						Console.WriteLine("{0}は素数です", num);
						break;
					} else
					{
						Console.WriteLine("{0}は素数ではありません", num);
						break;
					}
				}
			}
		}

		static public void GetPrimeNumber2()
		{
			Console.WriteLine("すべての素数を求める範囲を設定してください");
			Console.Write("2 ～ ");
			int num = int.Parse(Console.ReadLine());

			var prime = new List<int> { };
			int limit;

			for (var n = 2; n <= num; n++)
			{
				for (limit = (int)Math.Sqrt(n); limit > 1; limit--)
				{
					if (n % limit == 0)
					{
						break;
					}
				}
				
				if (limit == 1)
				{
					prime.Add(n);
				}
			}

			Console.WriteLine("2～{0}の範囲内での素数一覧", num);
			foreach(var p in prime)
			{
				Console.WriteLine(p);
			}
		}

		//static public void Eratosthenes()
		//{
		//	Console.WriteLine("すべての素数を求める範囲を設定してください");
		//	int num = int.Parse(Console.ReadLine());

		//	var primes = new List<int> { };

		//	for (var i = 2; i <= num; i++)
		//	{
		//		primes[i] = 1;
		//	}

		//	int j, k;
		//	var limit = (int)Math.Sqrt(num);
		//	for (j = 2; j <= limit; j++)
		//	{
		//		if (primes[j] == 1)
		//		{
		//			for (k = 2 * j; k <= num; j++)
		//			{
		//				if (k % j == 0)
		//				{
		//					primes[k] = 0;
		//				}
		//			}
		//		}
		//	}

		//	Console.WriteLine("2～{0}の範囲内での素数一覧", num);

		//	var index = 0;
		//	foreach (var prime in primes)
		//	{
		//		if (prime == 0)
		//		{
		//			Console.WriteLine(index + 1);
		//		}
		//		index++;
		//	}
		//}

		static public void PrimeFactorization()
		{
			Console.WriteLine("素因数分解する整数を入力してください");
			var n = int.Parse(Console.ReadLine());

			var i = 2;
			while (n >= i * i)
			{
				if (n % i == 0)
				{
					Console.Write("{0}*", i);
					n /= i;
				}
				else
				{
					i++;
				}
			}
			Console.Write(n);
		}
	}
}
