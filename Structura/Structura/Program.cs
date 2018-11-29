using System;

namespace Structura
{
    class Program
    {
        static void Main(string[] args)
        {
            //перадаеv данные в структуру
            /*Book book; // создаем объект типа структура Book
            book.name = "Война и мир";
            book.author = "Лев Толстой";
            book.year = 1898;

            //Выведем информацию о книге book на экран
            book.Info();*/

            Book1 book1 = new Book1("Евгений Онегин", "А.С. Пушкин", 1892);
            book1.Info();
        }
        struct Book
        {
            public string name;
            public string author;
            public int year;

            public void Info()
            {
                Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
            }
        }
        /*струтура с конструктором. Конструктор по сути является обычным методом, 
         только не имеет возвращаемого значения, и его название всегда совпадает с именем структуры или класса.*/
        struct Book1
        {
            public string name;
            public string author;
            public int year;
            
            public Book1(string n, string a, int y)  //конструктор
            {
                name = n;
                author = a;
                year = y;
            }
            public void Info()
            {
                Console.WriteLine("Книга '{0}' (автор {1}) была издана в {2} году", name, author, year);
            }
        }
    }
}
