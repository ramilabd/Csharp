using System;

namespace Fibonachi__array
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Введите число");
			int n = Int32.Parse(Console.ReadLine());
			Fib(n);
			
		}
		public static void Fib(int n)
		{
			int[] massiv = new int[n];
			massiv[0] = 0;
			massiv[1] = 1;
			massiv[2] = 1;

			int j1 = 1;
			int j2 = 2;

			for (int i = 3; i <= massiv.Length - 1 ; i++, j1++, j2++)
			{
				massiv[i] = massiv[j1] + massiv[j2];
			}

			foreach (int m in massiv)
			{
				Console.WriteLine(m);
			}
		}
	}
}
