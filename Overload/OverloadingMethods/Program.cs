using System;

namespace OverloadingMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			/*State s1 = new State { Name = "USA", Area = 245.4, Population = 6586 };
			State s2 = new State { Name = "USSR", Area = 326.8, Population = 5687 };
			if(s1 > s2)
			{
				Console.WriteLine("Государство USA больше государства USSR");
			}
			else if (s1 < s2)
			{
				Console.WriteLine("Государство USA меньше государства USSR");
			}
			else
			{
				Console.WriteLine("Государство USA и государства USSR равны");
			}*/

			State s3 = new State { Name = "USA", Area = 5.3, Population = 150 };
			State s4 = new State { Name = "USSR", Area = 6.7, Population = 250 };
			State s5 = s3 + s4;
			Console.WriteLine("Создано новое государство, название {0}, площадь {1}, население {2}", s5.Name, s5.Area, s5.Population);
		}
	}
}
