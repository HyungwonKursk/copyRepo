using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTestTask
{
	public class Triangle : IFigure
	{
		public double EdgeA { get; }
		public double EdgeB { get; }
		public double EdgeC { get; }

		public Triangle(double edgeA, double edgeB, double edgeC)
		{
			if (edgeA <= 0)
				throw new ArgumentException("Неверное значение для стороны.", nameof(edgeA));

			if (edgeB <= 0)
				throw new ArgumentException("Неверное значение для стороны.", nameof(edgeB));

			if (edgeC <= 0)
				throw new ArgumentException("Неверное значение для стороны.", nameof(edgeC));

			var maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
			var perimeter = edgeA + edgeB + edgeC;
			if (maxEdge > perimeter - maxEdge)
				throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон.");

			EdgeA = edgeA;
			EdgeB = edgeB;
			EdgeC = edgeC;
		}

		public double GetSquare()
		{
			var halfPerim = (EdgeA + EdgeB + EdgeC) / 2d;
			var square = Math.Sqrt(halfPerim * (halfPerim - EdgeA) * (halfPerim - EdgeB) * (halfPerim - EdgeC));
			return square;
		}

		public bool IsRightTriangle()
        {
			var maxEdge = Math.Max(EdgeA, Math.Max(EdgeB, EdgeC));

			if (Math.Pow(maxEdge, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2))
				return true;
			if (Math.Pow(maxEdge, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
				return true;
			if (Math.Pow(maxEdge, 2) == Math.Pow(EdgeC, 2) + Math.Pow(EdgeB, 2))
				return true;

			return false;
		}


	}
}
