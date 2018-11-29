using System;

namespace OverloadingMethods
{
	class State
	{
		// Перегрузка методов и операторов https://metanit.com/sharp/tutorial/3.5.php
		public string Name { get; set; }     // название
		public int Population { get; set; }  // население 
		public double Area { get; set; }     // площадь

		public void Attack(State enemy)
		{

		}
		public void Attack(State enemy, int army)
		{

		}
		public static State operator +(State s1, State s2)
		{
			string name = s1.Name;
			int people = s1.Population + s2.Population;
			double area = s1.Area + s2.Area;

			return new State { Name = name, Population = people, Area = area };
		}
		public static bool operator <(State s1, State s2)
		{
			if(s1.Area < s2.Area)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator >(State s1, State s2)
		{
			if(s1.Area > s2.Area)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
