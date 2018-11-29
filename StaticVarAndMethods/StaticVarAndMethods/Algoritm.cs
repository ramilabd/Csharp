using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVarAndMethods
{
	class Algoritm
	{
		public static double pi = 3.14;   // статическая переменная
		public static int Factorial(int x) // статический метод
		{
			if(x == 0) {return 1;}
			else
			{
				return x * Factorial(x - 1);
			}
		}
		public static int Fibonachi(int x) // статический метод
		{
			if (x == 0 | x == 1) { return 1; }
			else
			{
				return Fibonachi(x - 1) + Fibonachi(x - 2);
			}
		}
	}
}
