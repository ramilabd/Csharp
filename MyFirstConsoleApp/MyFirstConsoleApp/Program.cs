using System;
using myInt = System.Int32;
namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            int x = int.MaxValue;
            double y = i + x;
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
