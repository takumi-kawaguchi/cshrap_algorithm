using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.Polymo
{
	class Triangle : IFigure
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Triangle(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public double GetArea()
		{
			return this.Width * this.Height / 2;
		}
	}

	class Square : IFigure
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Square(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public double GetArea()
		{
			return this.Width * this.Height;
		}
	}
}
