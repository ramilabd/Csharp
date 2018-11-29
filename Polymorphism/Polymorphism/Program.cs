using System;

namespace Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			/*При определении класса-наследника и наследовании методов базового класса мы можем 
			 * выбрать одну из следующих стратегий:
				1. Обычное наследование всех членов базового класса в классе-наследнике
				2. Переопределение членов базового класса в классе-наследнике
				3. Скрытие членов базового класса в классе-наследнике
				В базовом классе Person метод Display() определен с модификаторами virtual, 
				поэтому данный метод может быть переопределен. Но класс Employee наследует его как есть:*/

			/*
			 * 1.Обычное наследование всех членов базового класса в классе - наследнике
			Person p1 = new Person("Bill", "Geytz");
			p1.InfoDisplay();                                   // вызов метода Display из класса Person

			Person p2 = new Employee("Tom", "Dgerry", "IBM");
			p2.InfoDisplay();                                  // вызов метода Display из класса Person

			Employee p3 = new Employee("Sam", "Tommy", "Gredit bank");
			p3.InfoDisplay();                                  // вызов метода Display из класса Person
			*/

			/*2.Переопределение членов базового класса в классе - наследнике
			Person p1 = new Person("Bill", "Geytz");
			p1.InfoDisplay();                                   // вызов метода Display из класса Person

			Person p2 = new Employee("Tom", "Dgerry", "IBM");
			p2.InfoDisplay();                                  // вызов метода Display из класса Employee

			Employee p3 = new Employee("Sam", "Tommy", "Gredit bank");
			p3.InfoDisplay();                                  // вызов метода Display из класса Employee
			*/

			/*3. Скрытие членов базового класса в классе-наследнике
			Person p1 = new Person("Bill", "Geytz");
			p1.InfoDisplay();                                   // вызов метода Display из класса Person

			Person p2 = new Employee("Tom", "Dgerry", "IBM");
			p2.InfoDisplay();                                  // вызов метода Display из класса Person

			Employee p3 = new Employee("Sam", "Tommy", "Gredit bank");
			p3.InfoDisplay();                                  // вызов метода Display из класса Employee
			*/

			/*Ключевое слово base - обращение к членам базового класса
			Employee p3 = new Employee("Sam", "Tommy", "Gredit bank");
			p3.InfoDisplay();*/
		}
	}
}
