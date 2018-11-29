using System;

namespace SummaNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет суммы всех чисел от 0 до ... Введите число. Для выхода из программы введите 0.");
            do
            {
                summa();
            } while (System.Int32.Parse(Console.ReadLine()) != 0);
        }
        static void summa()
        {
            Console.WriteLine("Введите число");
            int x = System.Int32.Parse(Console.ReadLine());
            int y = 0;
            while (x > 0)
            {
                for (int i = 0; i <= x; i++)
                {
                    y = y + i;
                }
                Console.WriteLine(y);
                x = 0;
            }
        }
    }
}
