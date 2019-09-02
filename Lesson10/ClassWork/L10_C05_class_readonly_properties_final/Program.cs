using System;

class Program
{
	static void Main()
	{
		Person p1 = new Person();
		p1.Name = "Andrei";
		p1.Age = 36;

		// Now we shouldn't think about the format of output for parameters in the main code.
		// We can just call PropertiesString where all the logic is encapsulated.
		Console.WriteLine(p1.PropertiesString);

		// The line below will not be compiled as the property is read-only!
		// p1.PropertiesString = "Try to override read-only property";
	}
}

class Person
{
	private int _age;
	public int Age
	{
		get { return _age; }
		set
		{
			if (value > 0 && value < 140)
			{
				_age = value;
			}
		}
	}

	public string Name { get; set; }

	public string PropertiesString
	{
		get { return $"Name: {Name}, Age: {Age}."; }
	}
}
