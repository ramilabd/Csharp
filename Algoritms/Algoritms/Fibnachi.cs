using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Fibnachi
    {
        public int FibonachiRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }

        public void FibbonachiArray(int n)
        {
            var arrayNumbers = new int[n];
            arrayNumbers[0] = 0;
            arrayNumbers[1] = 1;
            arrayNumbers[2] = 1;

            var j1 = 1;
            var j2 = 2;

            for (var i = 3; i <= arrayNumbers.Length - 1; i++, j1++, j2++)
            {
                arrayNumbers[i] = arrayNumbers[j1] + arrayNumbers[j2];
            }

            foreach (var m in arrayNumbers)
            {
                Console.WriteLine(m);
            }
        }

    }
}
