using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var fib = new Fibnachi();
            //fib.FibbonachiArray(8);

            var scip = new ScipHexlet();
            Console.WriteLine(scip.F(1));
        }
    }
}
