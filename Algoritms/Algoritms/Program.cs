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
            var sicp = new Sicp();

            var number = 2;
            var degree = 5;

            Console.WriteLine(sicp.ExponentiationIterativeUp(number, degree));

            Console.WriteLine(sicp.ExponentiationRecursionDegreeDivisionTwo(number, degree));
        }
    }
}