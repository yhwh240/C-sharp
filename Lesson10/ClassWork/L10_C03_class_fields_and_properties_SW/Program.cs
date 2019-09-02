using System;


namespace L10_C02_class_fields_and_properties_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet();
			pet1.Kind = Pet.AnimalKind.Cat;
			pet1.Name = "Tom";
			pet1.Sex = 'M';
			pet1.DateOfBirth = DateTimeOffset.Parse("2011-03-14");
			pet1.WriteOutDescription();
			pet1.UpdateProperties("Aaron", 'M', Pet.AnimalKind.Dog);
			pet1.WriteOutDescription();

			Pet pet2 = new Pet
			{
				Kind = Pet.AnimalKind.Mouse,
				Name = "Minnie",
				Sex = 'F',
				DateOfBirth = DateTimeOffset.Parse("2017-03-17")
			};
			pet2.UpdateProperties("Mike", 'F');
			pet2.WriteOutDescription();

			Pet pet3 = new Pet(Pet.AnimalKind.Dog, DateTimeOffset.Parse("2009-03-14"));
			pet3.WriteOutDescription();

			Console.ReadKey();
		}
	}
}