using System;

namespace StaticVarAndMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Console.WriteLine(Algoritm.pi);
			int y = Algoritm.Factorial(5);
			int z = Algoritm.Fibonachi(6);
			Console.WriteLine(y);
			Console.WriteLine(z);*/

			// создание объектов типа Counter, с помощью конструктора Counter(), которые будут изменять значение общей
			// статической переменной counter
			Counter c1 = new Counter(); 
			Counter c2 = new Counter();
			Counter c3 = new Counter();
			Counter c4 = new Counter();
			Counter c5 = new Counter();

			Counter.InfoCounter();
		}
	}
}
