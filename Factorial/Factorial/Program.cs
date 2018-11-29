using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет факториала числа. Введите число. Для выхода из программы введите 0.");
            do
            {
                factorial();
            } while (System.Int32.Parse(Console.ReadLine()) != 0);
        }
        static void factorial()
        {
            Console.WriteLine("Введите число");
            int x = System.Int32.Parse(Console.ReadLine());
            long y = 1;
            while (x > 0)
            {
                for (int i = 1; i <= x; i++)
                {
                    y *= i;
                }
                Console.WriteLine(y);
                x = 0;
            }
        }
    }
}
