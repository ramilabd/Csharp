using System;

namespace StaticVarAndMethods
{
	class Counter
	{
		//На уровне памяти для статических полей будет создаваться участок в памяти,
		//который будет общим для всех объектов класса. 
		public static int counter = 0; // статические поле 
		
		public Counter() //конструктор класса
		{
			counter++;
		}

		public static void InfoCounter() //статический метод
		{
			Console.WriteLine("Создано объектов Сounter {0}", counter);
		}
	}
}
