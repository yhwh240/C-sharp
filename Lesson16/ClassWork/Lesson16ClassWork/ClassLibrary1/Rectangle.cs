using System;

namespace Figures
{
	public class Rectangle
	{
		private double _sideA;
		private double _sideB;

		public Rectangle(double a, double b)
		{
			_sideA = a;
			_sideB = b;
		}

		public double Calculate(Func<double, double, double> operation)
		{
			return operation(_sideA, _sideB);
		}
	}
}
