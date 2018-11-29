using System;

namespace AvtoProperties
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			Console.WriteLine(p.name);
			Console.WriteLine(p.age);

		}
	}
	class Person
	{
		public string name { get; set; }
		public int age { get; set; }

		public void GeterSeter(string x, int y)
		{
			name = x;
			age = y;
			Console.WriteLine(name, age);
		}


	}
}
