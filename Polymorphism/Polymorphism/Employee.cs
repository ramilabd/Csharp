using System;

namespace Polymorphism
{
	class Employee : Person
	{
		public string Company { get; set; }

		public Employee(string fName, string lName, string comp)
			:base (fName, lName)
		{
			Company = comp;
		}

		/*2.Переопределение членов базового класса в классе - наследнике
		public override void InfoDisplay()
		{
			Console.WriteLine(FirstName + " " + LastName + " компания " + Company);
		}*/

		/*3. Скрытие членов базового класса в классе-наследнике
		public new void InfoDisplay()
		{
			Console.WriteLine(FirstName + " " + LastName + " компания " + Company);
		}
		*/

		/*Ключевое слово base - обращение к членам базового класса*/
		public override void InfoDisplay()
		{
			base.InfoDisplay();                         // вызов метода Display из класса Person
			Console.WriteLine(" компания " + Company);  // вызов метода Display из класса Employee
		}
	}
}
