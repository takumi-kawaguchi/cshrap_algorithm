using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Sort
	{
		static public void Select()
		{
			var list = new List<int> { };
			bool answer;

			Console.WriteLine("ソートする配列を設定してください");
			do
			{
				var i = int.Parse(Console.ReadLine());
				list.Add(i);
				Console.WriteLine("まだ配列に数値を追加しますか？： y/n");
				if (Console.ReadLine() == "y")
				{
					answer = true;
				} else
				{
					answer = false;
				}
			} while (answer);

			for (var i = 0; i < list.Count - 1; i++)
			{
				var min = list[i];
				var s = i;
				for (var j = i + 1; j < list.Count; j++)
				{
					if (list[j] < min)
					{
						min = list[j];
						s = j;
					}
				}
				var t = list[i]; list[i] = list[s]; list[s] = t;
			}
			foreach (var l in list)
			{
				Console.Write("{0}, ", l);
			}
			Console.Write("\n");
		}

		static public void Bubble()
		{
			var list = new List<int> { };
			bool answer;

			Console.WriteLine("ソートする配列を設定してください");
			do
			{
				var i = int.Parse(Console.ReadLine());
				list.Add(i);
				Console.WriteLine("まだ配列に数値を追加しますか？： y/n");
				if (Console.ReadLine() == "y")
				{
					answer = true;
				}
				else
				{
					answer = false;
				}
			} while (answer);

			for (var i = 0; i < list.Count - 1; i++)
			{
				for (var j = list.Count - 1; j > i; j--)
				{
					if (list[j] < list[j - 1])
					{
						var tmp = list[j];
						list[j] = list[j - 1];
						list[j - 1] = tmp;
					}
				}
			}

			foreach (var l in list)
			{
				Console.Write("{0} ", l);
			}
			Console.WriteLine();
		}

		static public void Shaker()
		{
			var list = new List<int> { };
			bool answer;

			Console.WriteLine("ソートする配列を設定してください");
			do
			{
				var i = int.Parse(Console.ReadLine());
				list.Add(i);
				Console.WriteLine("まだ配列に数値を追加しますか？： y/n");
				if (Console.ReadLine() == "y")
				{
					answer = true;
				}
				else
				{
					answer = false;
				}
			} while (answer);

			var left = 0;
			var right = list.Count - 1;
			int shift = 0;
			while (left < right)
			{
				for (var i = left; i < right; i++)
				{
					if (list[i] > list[i + 1])
					{
						var tmp = list[i];
						list[i] = list[i + 1];
						list[i + 1] = tmp;
						shift = i;
					}
				}

				right = shift;
				for (var i = right; i > left; i--)
				{
					if (list[i] < list[i - 1])
					{
						var tmp = list[i];
						list[i] = list[i - 1];
						list[i - 1] = tmp;
						shift = i;
					}
				}

				left = shift;
			}

			foreach (var l in list)
			{
				Console.Write("{0} ", l);
			}
			Console.WriteLine();
		}
	}
}
