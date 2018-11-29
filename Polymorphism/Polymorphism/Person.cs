using System;

namespace Polymorphism
{
	class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Person (string fName, string lName)
		{
			FirstName = fName;
			LastName = lName;
		}

		public virtual void InfoDisplay()
		{
			Console.WriteLine(FirstName + " " + LastName);
		}
	}
}
