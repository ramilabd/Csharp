using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class CycleForeach
    {
        int[] nums = new int[5] {1, 2, 5, 6, 3};

        public void metodForeach()
        {
            foreach(int n in nums)
            {
                Console.WriteLine(n);
            }
        }

    }
}
