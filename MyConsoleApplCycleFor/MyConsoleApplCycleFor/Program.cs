using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplCycleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 10;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                x = x * 2;
            }
            Console.WriteLine(x);*/

             int[] myArray = new int[3];
             myArray[0] = 1;
             myArray[1] = 2;
             myArray[2] = 3;

            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
