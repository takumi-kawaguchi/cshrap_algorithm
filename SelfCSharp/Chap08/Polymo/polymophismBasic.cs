using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08.Polymo
{
	class Figure
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public Figure(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public virtual double GetArea()
		{
			return 0.0;
		}
	}

	class Triangle : Figure
	{
		public Triangle(double width, double height) : base(width, height) { }

		public override double GetArea()
		{
			return this.Width * this.Height / 2;
		}
	}

	class Square : Figure
	{
		public Square(double width, double height) : base(width, height) { }

		public override double GetArea()
		{
			return this.Width * this.Height;
		}
	}
}
