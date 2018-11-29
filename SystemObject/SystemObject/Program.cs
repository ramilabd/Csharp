using System;

namespace SystemObject
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Для класса Person метод ToString() переопределен с помощью ключевого слова override и выводит значение свойства Name. 
			 * А для класса Human срабатывает стандартная реализация этого метода, которая выводит просто название класса.*/

			Person p = new Person();
			p.Name = "Tom";
			Console.WriteLine(p.ToString());
			Console.WriteLine(p.GetType());
			Console.WriteLine(p.Name.GetType());

			Human h = new Human();
			Console.WriteLine(h.ToString());

			/*Метод GetHashCode позволяет задать некоторое числовое значение, которое будет соответствовать данному 
			 * объекту или его хэш-код. 
			 * По данному числу, например, можно сравнивать объекты. 
			 * Можно определять самые разные алгоритмы генерации подобного числа или взять реализаци базового типа:*/
			Human h1 = new Human();
			Console.WriteLine(h1.GetHashCode());
			Console.WriteLine(h1.GetType());   // возвращает тип ОБЪЕКТА

			Console.WriteLine(typeof(Human));  // возвращает тип КЛАССА

			/*Метод Equals позволяет сравнить два объекта на равенство. Метод Equals принимает в качестве параметр объект 
			 * любого типа, который мы затем приводим к текущему, если они являются объектами одного класса. 
			 * Затем сравниваем по именам. Если имена равны, возвращаем true, что будет говорить, что объекты равны.*/

		}
	}
}
