using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleAppCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cycle 'while'");
            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine(x); //Можно написать так: Console.WriteLine(x++); без x++;
                x++;
            }

            Console.WriteLine("Cycle 'do while'");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i<=10);
            
            //Можно так:
            Console.WriteLine("Cycle 'do while'");
            int a = 0;
            do
            {
                Console.WriteLine(a);
            } while (++a <= 10);
        }
    }
}
