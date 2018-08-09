using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Example
	{
		public int TotalProducts(params int[] values)
		{
			int result = 1;
			foreach (var value in values)
			{
				result *= value;
			}
			return result;
		}

		public int CountUp(int data)
		{
			data++;
			return data;
		}

		public int[] Update(int[] data)
		{
			data[0] = 5;
			return data;
		}

		public int CountUp(ref int data)
		{
			data++;
			return data;
		}

		public int[] Update(ref int[] data)
		{
			data[0] = 5;
			return data;
		}

		public ref int ReturnRef(int[] data)
		{
			return ref data[0];
		}

		public void GetMaxMin(int x, int y, out int max, out int min)
		{
			if (x > y)
			{
				max = x;
				min = y;
			}
			else
			{
				max = y;
				min = x;
			}
		}

		public (int max, int min) GetMaxMin(int x, int y)
		{
			return x >= y ? (x, y) : (y, x);
		}
	}
}
