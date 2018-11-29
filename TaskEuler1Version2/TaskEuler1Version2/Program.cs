using System;

namespace TaskEuler1Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers(10); // просто вызвать метод: список чисел
            NumbersInArray(10);
        }
        static void Numbers(int x) // void используется вместе с return
        {
            if (x == 0) return; // Условие проверяющее, что допустим дальше расчитывать смысла нет и поэтому
                                //вызываем return завершающее данную функцию и возвращающее управление Main
            for (int i = 1; i < x; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        
        static int NumbersInArray(int x) 
        {
            if (x == 0) return 0;
            int[] massiv = new int[10];
            for (int j = 0; j <= massiv.Length; j++)
            {
                int temp = 0;
                for (int i = 1; i < x; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        temp = i;
                    }
                }
                massiv[j] = temp;
            }
            return 0;
        }
    }
}
