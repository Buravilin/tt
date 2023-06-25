using System;
using System.Reflection.Metadata.Ecma335;
using FigLibrary;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests
{
	public class TriangleTest
	{
		[TestCase(-1, 1, 1)]
		[TestCase(1, -1, 1)]
		[TestCase(1, 1, -1)]
		[TestCase(0, 0, 0)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}
		[Test]
		public void InitTriangleTest()
		{
			double a = 3d, b = 4d, c = 5d;
			var triangle = new Triangle(a, b, c);
			Assert.NotNull(triangle);
			Assert.Less(Math.Abs(triangle.sideA - a), 1);
			Assert.Less(Math.Abs(triangle.sideB - b), 1);
			Assert.Less(Math.Abs(triangle.sideC - c), 1);
		}

		[Test]
		public void GetAreaTest()
		{
			double a = 3d, b = 4d, c = 5d;
			double result = 6d;
			var triangle = new Triangle(a, b, c);
			var area = triangle?.GetArea();
			Assert.NotNull(area);
			Assert.Less(Math.Abs(area.Value - result), 1);
		}

	}
}