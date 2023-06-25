using System;
using FigLibrary;
using NUnit.Framework;

namespace Tests
{
	public class CircleTest
	{

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void ZeroRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(0d));
		}

		[Test]
		public void GetAreaTest()
		{
			var radius = 7;
			var circle = new Circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2d);
			var area = circle.GetArea();

			Assert.Less(area - expectedValue, 1);
		}
	}
}