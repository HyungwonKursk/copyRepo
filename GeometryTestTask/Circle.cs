using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTestTask
{
	public class Circle : IFigure
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Неверно указан радиус.", nameof(radius));
			Radius = radius;
		}

		public double GetSquare()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}
	}
}
