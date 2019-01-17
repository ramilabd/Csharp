using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class ScipHexlet
    {
        /*
         f(n) = n                                    if n < 3,
         f(n) = f(n - 1) + 2f(n - 2) + 3f(n - 3)     if n >= 3.
        */

        public int F(int n)
        {
            if (n < 3)
            {
                return n;
            }
            else if (n >= 3)
            {
                return F(n - 1) + (2 * F(n - 2)) + (3 * F(n - 3));
            }
        }

    }
}
