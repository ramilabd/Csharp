using System;

namespace Constructor
{
	class Program
	{
		static void Main(string[] args)
		{
			//создаем новый объект типа Book 
			//и передаем ему параметры для первичной инициализации полей объекта при его создании
			Book b = new Book("Voyna and mir", "Lev Tolstoy", 1856);
			b.InfoDisplay();

			// создаем новый объект типа Book
			//без передачи параметров для первичной инициализации полей объекта при его создании
			//но поля объекта заполняться данными по умолчанию которые прописаны в блоке конструктора Book()
			Book b2 = new Book(); 
			b2.InfoDisplay();

			//инциализатор объекта, без явного вызова конструктора
			Book b3 = new Book { nameBook = "О царе Салтане", authorBook = "Пушкин", yearBook = 1825 };
			b3.InfoDisplay();
		}
	}
}
