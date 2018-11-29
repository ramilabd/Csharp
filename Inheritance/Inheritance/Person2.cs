using System;

namespace Inheritance
{
	class Person2
	{
		private string firstname2;
		private string lastname2;

		public string Firstname2 { get; set; }
		public string Lastname2 { get; set; }

		// добавил конструктор
		public Person2(string fName, string lName)
		{
			firstname2 = fName;
			lastname2 = lName;
		}

		public void InfoDisplay()
		{
			Console.WriteLine(Firstname2 + " " + Lastname2);
		}
	}
}
