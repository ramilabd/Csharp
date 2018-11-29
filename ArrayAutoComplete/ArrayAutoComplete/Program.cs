using System;

namespace ArrayAutoComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] copy= ArrayFilling(10);
            foreach(int res in copy)
            {
                Console.WriteLine(res);
            }
        }
        static int[] ArrayFilling(int x)
        {
            //if (x == 0) return 0;
            int[] massiv = { };
            int j = -1;
            for (int i = 1; i < x ; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                    j++;
                        massiv[j] = i;
                    }
                }
            return massiv;
        }
    }
}
