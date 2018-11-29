using System;

namespace Readonly
{
	class Program
	{
		static void Main(string[] args)
		{
			Read r = new Read(3);  // вызов конструктора
			Console.WriteLine(r.x);
		}
	}
}
