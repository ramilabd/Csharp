using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("нажмите цифру 1 или 0");
            string x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("вы нажали 1");
                    break;
                case "0":
                    Console.WriteLine("вы нажали 0");
                    break;
                default:
                    Console.WriteLine("вы нажали другое число");
                    break;*/

            Ternary b = new Ternary(25, 15);
            b.metodTernary();
        }
    }
}
