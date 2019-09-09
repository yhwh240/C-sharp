using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13ClassWork
{
	public abstract class FlyingObject
	{
		public int MaxHeight { get; private set; }
		public int CurrentHeight { get; private set; }

		public FlyingObject(int maxHeight)
		{
			MaxHeight = maxHeight;
			CurrentHeight = 0;
		}

		public void TakeUpper(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			else if (CurrentHeight + delta > MaxHeight)
			{
				CurrentHeight = MaxHeight;
			}
			else
			{
				CurrentHeight += delta;
			}
		}

		public void TakeLower(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			else if (CurrentHeight > delta)
			{
				CurrentHeight -= delta;
			}
			else if (CurrentHeight == delta)
			{
				CurrentHeight = 0;
				Console.WriteLine("Landing...");
			}
			else if (CurrentHeight < delta)
			{
				throw new InvalidOperationException("Crash!");
			}
		}



	}
}
