using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Search
	{
		static public void Linear()
		{
			var people = new List<Person>
			{
				{new Person("Alpha", 1)},
				{new Person("Bravo", 2)},
				{new Person("Charlie", 3)},
				{new Person("Delta", 4)},
				{new Person("Echo", 5)},
				{new Person("Foxtrot", 6)},
				{new Person("Golf", 7)},
				{new Person("Hotel", 8)},
				{new Person("India", 9)},
				{new Person("Juliett", 10)}
			};

			Console.WriteLine("どのデータを探しますか？");
			var target = Console.ReadLine();

			for (var i = 0; i < people.Count; i++)
			{
				if (people[i].name == target)
				{
					Console.WriteLine("{0} ({1})", people[i].name, people[i].age);
					break;
				}

				if (i == people.Count - 1)
				{
					Console.WriteLine("データは見つかりませんでした");
				}
			}
		}
	}
}
