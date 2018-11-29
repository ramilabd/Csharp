using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Циклы: for, foreach, while, do while */
/* угадай число */

namespace Cycles
{
    class CycleWhile
    {
        int x = 5;
        int i = 1;

        public void While()
        {
            Console.WriteLine("угадайте число от 1 до 10");

            while (x != Int32.Parse(Console.ReadLine()))
            {
                Console.WriteLine("неверно, еще раз");
                i++;
            }
            Console.WriteLine("вы угадали число, количество попыток " + i);
        }
    }
}
