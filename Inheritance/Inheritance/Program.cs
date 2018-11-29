using System;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person { Firstname = "Tom", Lastname = "Bill"};  // инициализатор объекта
			p.Display();

			p = new Employee { Firstname = "Denis", Lastname = "Rich" };    // инициализатор объекта
			p.Display();

			Person2 p2 = new Person2 { Firstname2 = "Tommy", Lastname2 = "Billi" };

			p2 = new Employee2 { Firstname2 = "Tom", Lastname2 = "Bill", Company = "Microsoft" };
		}
	}
	
	
}