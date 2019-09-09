using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13ClassWork
{
	public class Plane : FlyingObject
	{
		public byte EngineCount { get; }

		public Plane(int maxHeight, byte engineCount) : base(maxHeight)
		{
			EngineCount = engineCount;
			Console.WriteLine("It's a plane, welcome aboard!");
		}

		public void WriteAllProperties()
		{
			Console.WriteLine($"EngineCount: {EngineCount} \n" +
				$"CurrentHeight: {CurrentHeight}\n" +
				$"MaxHeight:{MaxHeight}");
		}

	}
}
