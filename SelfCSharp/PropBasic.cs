using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
	class Triangle
	{
		private double _width;
		private double _height;

		public double Width
		{
			get { return this._width; }

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("正数で指定してください");
				}
				this._width = value;
			}
		}

		public double Height
		{
			get { return this._height; }

			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("正数で指定してください");
				}
				this._height = value;
			}
		}

		public double GetArea()
		{
			return Width * Height / 2;
		}
	}
}
