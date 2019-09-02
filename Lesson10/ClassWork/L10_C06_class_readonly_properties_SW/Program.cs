using System;

public class Pet
{
	public enum AnimalKind { Mouse, Cat, Dog }

	private string _birthPlace;

	public AnimalKind Kind;
	public string Name;

	public char Sex{ get; set; }
	public byte Age { get; set; }

	public string Description
	{
		get { return $"{Name} is a {Kind} ({Sex}) of {Age} years old."; }
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

		Console.WriteLine(pet1.Description);

		Pet pet2 = new Pet
		{
			Kind = Pet.AnimalKind.Mouse,
			Name = "Minnie",
			Sex = 'F',
			Age = 1
		};

		Console.WriteLine(pet2.Description);
	}
}
