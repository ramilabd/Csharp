using System;

/*Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел - 23.
  Найдите сумму всех чисел меньше 1000, кратных 3 или 5.*/
namespace TaskEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers(10); // просто вызвать метод: список чисел 
            Console.WriteLine(); // новая строка для отступа
            Console.WriteLine(summaNumbers(10)); // сумма чисел
        }
        static int summaNumbers(int x)
        {
            int temp = 0;
            for (int i = 1; i < x; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    temp = temp + i;
                }
            }
            return temp;
        }
        static void Numbers(int x)
        {
            for (int i = 1; i < x; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
