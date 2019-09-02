﻿using System;

public class Pet
{
	public enum AnimalKind { Mouse, Cat, Dog }

	private string _birthPlace;
	private char _sex;

	public AnimalKind Kind;
	public string Name;

	public char Sex
	{
		get
		{
			return _sex;
		}
		set
		{
			if (value == 'f' || value == 'F' || value == 'm' || value == 'M')
			{
				_sex = char.ToUpper(value);
			}
			else
			{
				throw new Exception("Invalid value");
			}
		}
	}
	public byte Age { get; set; }

	public string Description
	{
		get
		{
			return $"{Name} is a {Kind} ({Sex}) of {Age} years old" +
				$" (birth place: {_birthPlace}.";
		}
	}

	public void SetBirthPlace(string birthPlace)
	{
		_birthPlace = birthPlace;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Pet pet1 = new Pet();
		pet1.Kind = Pet.AnimalKind.Cat;
		pet1.Name = "Tom";
		pet1.Sex = 'M';
		pet1.Age = 8;
		pet1.SetBirthPlace("Moscow");
		Console.WriteLine(pet1.Description);


		Pet pet2 = new Pet
		{
			Kind = Pet.AnimalKind.Mouse,
			Name = "Minnie",
			Sex = 'F',
			Age = 1
		};
		pet2.SetBirthPlace("St.Petersburg");

		Console.WriteLine(pet2.Description);
	}
}
