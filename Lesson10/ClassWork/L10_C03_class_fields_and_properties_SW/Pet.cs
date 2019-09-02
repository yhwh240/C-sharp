using System;
using System.Collections.Generic;
using System.Text;

namespace L10_C02_class_fields_and_properties_SW
{
	class Pet
	{
		public enum AnimalKind { Mouse, Cat, Dog }

		public AnimalKind Kind;
		public string Name;

		public char Sex { get; set; }
		public DateTimeOffset DateOfBirth;


		public int Age()
		{
			var time = DateTimeOffset.Now - DateOfBirth;
			return Convert.ToInt32(Math.Floor(time.Days / 365.242));
		}

		public string Description
		{
			get
			{
				return $"{Name} is a {Kind} " + $"({Sex}) of {Age()} years old.";
			}
		}

		public string ShortDescription
		{
			get
			{
				return $"{Name} is a {Kind}";
			}
		}

		public void WriteOutDescription(bool IsShortDescription = false)
		{
			var output = IsShortDescription
				? ShortDescription
				: Description;
			Console.WriteLine(output);
		}

		public void UpdateProperties(string name, char sex)
		{
			Name = name;
			Sex = sex;
		}

		public void UpdateProperties(string name, AnimalKind kind)
		{
			Name = name;
			Kind = kind;
		}

		public void UpdateProperties(string name, char sex, AnimalKind kind)
		{
			Name = name;
			Kind = kind;
			Sex =  sex;
		}

		public Pet(AnimalKind kind)
		{
			Kind = kind;
			
		}

		public Pet(AnimalKind kind, DateTimeOffset date) : this(kind)
		{
			DateOfBirth = date;
		}
	}

}
