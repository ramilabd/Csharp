using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Operation oper = (x, y) => x + y;

            int z = oper(10, 20);
            Console.WriteLine(z);
        }
    }
}
