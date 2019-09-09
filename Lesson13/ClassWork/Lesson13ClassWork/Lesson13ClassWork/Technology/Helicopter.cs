using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13ClassWork
{
	public class Helicopter : FlyingObject
	{
		public byte BladesCount { get; }

		public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It's a helicopter, welcome aboard!");
		}

		public void WriteAllProperties()
		{
			Console.WriteLine($"BladesCount: {BladesCount} \n" +
				$"CurrentHeight: {CurrentHeight}\n" +
				$"MaxHeight:{MaxHeight}");
		}

	}
}
