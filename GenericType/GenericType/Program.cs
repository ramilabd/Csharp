using System;
using System.Collections.Generic;

namespace GenericType
{
	class Program
	{
		static void Main(string[] args)
		{
			/*int x = 45;
			string s = "h";
			List<int> array = new List<int>();
			array.Add(x);
			int y = array[0];			
			Console.WriteLine(y);*/

			Bank<int> bank = new Bank<int>(new int[] { 1, 2, 3 });


			foreach (int x in bank.clients)
			{
				Console.WriteLine(x);
			}

			//создание объекта с помощью вызова конструктора с передачей массива в качестве параметра:
			Bank_Int<int> bank1 = new Bank_Int<int>(new int[] { 1, 2, 3, 4, 5 }); 

		}
	}
}
