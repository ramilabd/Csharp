using System;

namespace Inheritance
{
	class Person
	{
		private string firstname;
		private string lastname;

		//Свойства используются для управления доступом к полям класса.
		public string Firstname //доступ и запись к полю firstname 
		{
			get { return firstname; }   //получить значение firstname
			set { firstname = value; }  //установить занчение firstname
		}
		public string Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}
		public void Display()
		{
			Console.WriteLine(Firstname + " " + Lastname);
		}
	}
}
