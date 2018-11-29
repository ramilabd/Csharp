using System;

namespace Constants
{
	class Program
	{
		static void Main(string[] args)
		{
			// константа - статическое поле, поэтому нам необязательно создавать объект класса с помощью конструктора. 
			//Мы можем обратиться к ней, используя имя класса.
			Console.WriteLine(Constanta.pi);

			//либо создаем объект для доступа к метоу
			Constanta c = new Constanta();
			c.InfoConst();

		}
	}
}
