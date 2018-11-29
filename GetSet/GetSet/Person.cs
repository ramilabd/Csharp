using System;

namespace GetSet
{
	class Person
	{
		private int x = 10;
		//private int y = 15;

		public int Properties  // имя свойства пишется без скобок: мод. доступа + тип возвращаемого значения + имя Properties
		{
			get // получить значение х
			{
				return x;
			}
			set // установить значение х
			{
				x = value;
			}
		}
	}
}
