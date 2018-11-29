using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double a = 1;
            double b = 4.3;
            double x;
            Console.WriteLine("Введите число double");
            string res = Console.ReadLine();
            if (double.TryParse(res, out x))
            {
                if ((x >= a) && (x <= b))
                {
                    Console.WriteLine("x in intervale");
                }
                else
                {
                    Console.WriteLine("x is not intervale");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }*/
            int caseSwitch = 5;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case = 1");
                    break;
                case 2:
                    Console.WriteLine("Case = 2");
                    break;
                default:
                    Console.WriteLine("No value");
                    break;
            }
        }
    }
}
