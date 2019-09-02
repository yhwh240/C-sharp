using System;

class Program
{
	static void Main()
	{
		Person p1 = new Person();

		// p1.m_age - inaccessible as it is private
		p1.Name = "Andrei";
		p1.Age = 36;

		Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}.");
		// Name: Andrei, Age: 36.
	}
}

class Person
{
	int _age;				// implicitly private field: bad practice! always use "private"!
							// "_" prefix is used for member variables

	public int Age			// another one public property
	{
		get					// getter of the property
		{
			return _age;
		}
		set					// setter of the property
		{
			if (value > 0 && value < 140) // logic of set
			{
				_age = value;
			}
		}
	}

	public string Name { get; set; } // public property
}
