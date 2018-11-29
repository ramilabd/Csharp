using System;

namespace GetSet
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			//вызов свойства Properties для получение значения закрытой переменной х
			int getX = p.Properties;  // имя свойства пишется без скобок: Properties
			Console.WriteLine(getX);

			Person p2 = new Person();
			//вызов свойства Properties для установки значения закрытой переменной х
			p2.Properties = 125; // вызов свойства Properties + передаваемое значение
			int getX2 = p2.Properties;
			Console.WriteLine(getX2);
		}
	}
		
}
