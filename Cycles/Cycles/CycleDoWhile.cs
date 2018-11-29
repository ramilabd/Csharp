using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class CycleDoWhile
    {
        int x = 1;

        public void DoWhile()
        {
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x != 10);

            Console.WriteLine($"х равен {x}", x);
        }
    }
}
