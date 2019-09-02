using System;

class Program
{
	static void Main()
	{
		Person p1 = new Person();
		p1.Name = "Andrei";
		p1.Age = 36;
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
}
