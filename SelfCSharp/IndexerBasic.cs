using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class FreeArray
	{
		private int _size;
		private int[] _list;

		public FreeArray(int size)
		{
			this._size = size;
			this._list = new int[size];
		}

		public int this[int index]
		{
			set
			{
				this._list[this.GetIndex(index)] = value;
			}

			get
			{
				return this._list[this.GetIndex(index)];
			}
		}

		private int GetIndex(int index)
		{
			if (index < 0)
			{
				return 0;
			}

			return index % this._size;
		}
	}
}
