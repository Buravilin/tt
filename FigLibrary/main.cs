using System;

namespace FigLibrary
{

	public interface Figure
    {
        double GetArea();
    }

    
	public class Circle : Figure
	{
		public double Radius { get; }

		public Circle(double radius)
        {
            if (Radius <= 0)
                throw new ArgumentException("Укажите радиус больше 0", nameof(Radius));
			Radius = radius;
		}

        public double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}
	}


	public class Triangle : Figure
	{
		public double sideA { get; }
		public double sideB { get; }
		public double sideC { get; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
			var perim = sideA + sideB + sideC;

			if ((sideA <= 0 && sideB <= 0 && sideC <= 0) == false)
				throw new ArgumentException("Некорректно указаны размеры, как минимум одной стороны");
			if ((perim - maxSide) < maxSide)
				throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");
		}


		public double GetArea()
		{
			var halfP = (sideA + sideB + sideC) / 2d;
			var area = Math.Sqrt(halfP
								* (halfP - sideA)
								* (halfP - sideB)
								* (halfP - sideC)
			);

			return area;
		}
	}
}