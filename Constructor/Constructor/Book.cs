using System;

namespace Constructor
{
	class Book
	{
		public string nameBook;
		public string authorBook;
		public int yearBook;
		
		//имя конструтора должно совпадать с именем класса, 
		//без типа возвращаемого занчения, этот конструктор без параметров
		public Book() 
		{
			nameBook = "неизвестно";
			authorBook = "неизвестно";
			yearBook = 0;
		}
		//имя конструтора должно совпадать с именем класса, 
		//без типа возвращаемого занчения, этот конструктор принимает параметры
		public Book(string bookName, string bookAuthor, int bookYear)
		{
			this.nameBook = bookName;
			this.authorBook = bookAuthor;
			this.yearBook = bookYear;
		}

		public void InfoDisplay()
		{
			Console.WriteLine("Название книги {0}, автор книги {1}, год издания {2}", nameBook, authorBook, yearBook);
		}
	}
}
