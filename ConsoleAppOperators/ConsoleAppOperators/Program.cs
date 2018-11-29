using System;

namespace ConsoleAppOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = System.Int32.Parse(Console.ReadLine());
            //int y = System.Int32.Parse(Console.ReadLine());
            int y = 100;
            Logik(x, y);  
        }
        public static void Logik(int x, int y)
        {
            if (x != 0 && y / x > 100)
            {
                Console.WriteLine(y);
            } 
            else
            {
                Console.WriteLine("x равен нулю");
            }
        }

    }
}
