using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                do
                {
                    Console.WriteLine("введите первое число");
                    int x = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("введите второе число");
                    int y = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма чисел {0} и {1} равна {2}", x, y, x + y);

                } while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
