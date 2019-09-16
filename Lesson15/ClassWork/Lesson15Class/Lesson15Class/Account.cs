using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15Class
{
	public class Account<T1, T2>
	{
		public static T1 Id{ get; private set; }
		public static T2 Name { get; private set; }

		public Account(T1 id, T2 name)
		{
			Id = id;
			Name = name;
		}

		public void WriteProperties()
		{
			Console.WriteLine($"Name: {Name}, Id: {Id}");
		}


	}
}
