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
	}
}
