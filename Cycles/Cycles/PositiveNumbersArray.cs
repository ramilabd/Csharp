using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class PositiveNumbersArray
    {
        int[] numbers = new[] { 1, 5, -6, -15, -4, 3, -1, -10, 7, 9, -5, -7, 2, 3, -15 };

        public void PositiveNumbers()
        {
            int countPositive = 0;
            int countNegative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    countPositive++;
                }
                else
                {
                    countNegative++;
                }
            }
            Console.WriteLine($"Количество положительных чисел в массиве {countPositive}, отрицательных {countNegative}");
        }

        public void Info()
        {
            Console.WriteLine($"длина массива {numbers.Length} элементов");
        }

        public void ElementsArray()
        {
            foreach (int n in numbers)
            {
                Console.Write(n + ", ");
            }
        }
    }
}
