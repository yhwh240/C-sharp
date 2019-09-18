using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lesson16ClassWork
{
	public class SimpleCalculator
	{
		public static int Sum(int x, int y)
		{
			Debug.WriteLine($"SimpleCalculator.Sum() called with arguments {x}, {y}");
			return x + y;
		}

		public static int Multiply(int x, int y)
		{
			Debug.WriteLine($"SimpleCalculator.Multiply() called with arguments {x}, {y}");
			return x * y;
		}

		public static int Divide(int x, int y)
		{
			Debug.WriteLine($"SimpleCalculator.Divide() called with arguments {x}, {y}");
			return x / y;
		}

	}
}
