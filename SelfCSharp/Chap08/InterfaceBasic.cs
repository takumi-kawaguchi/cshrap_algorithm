using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap08
{
	interface IFigure
	{
		double Width { get; set; }
		double Height { get; set; }

		double GetArea();
	}
}
