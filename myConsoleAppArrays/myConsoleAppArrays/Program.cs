using System;

namespace myConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[6] {"s","t","r","i","n","g"};
            foreach(string n in s){
                Console.WriteLine(n);
            }
            int d = s.Length; //для одномерного массива, в многомерном массиве возвращает общее кол-во элементов в массиве
            Console.WriteLine(s.GetLength(0)); /*для многомерного массива, возвращает кол-во элементов в массиве, а параметр, это измерение в 
                                                в котором высчитывается кол-во элементов*/
            Console.WriteLine(s.Rank); // возвращает размерность массива

            //AddElemInMassiv();
            //LengthArray();
            //SortArray();
        }
        
        static void AddElemInMassiv()
        {
            int[] massiv = new int[100];
            for (int i = 0; i< 100; i++) // присваивание элементам массива значения от 0 до 99 
            {
                massiv[i] = i;
            }
            
            foreach(int d in massiv) // вывод элементов массива
            {
                Console.WriteLine(d);
            }
        }

        static void LengthArray()
        {
            int[,] massiv2 = new int[10, 10]; 
            int x2 = massiv2.GetLength(0);
            int x3 = massiv2.Length;
            Console.WriteLine(x2);
            Console.WriteLine(x3);
        }
        static void SortArray() // сортировка элементов массива и вывод в порядке увеличения
        {
            int[] massiv = new int[] { 10, 12, 2, 13, 100, 5, -9, 8, 1, 16, 9, 6, 11, 3, 4, 7, -1, 0 };
            for (int i = 0; i < massiv.Length - 1; i++) //i индекс массива - для первого элемента - 10
            {
                for (int j = i + 1; j < massiv.Length; j++) // j индекс массива - для второго элемента j=i+1 - 12
                {
                    if (massiv[i] > massiv[j]){ // сравнение первого элемента i со вторым j
                        int temp = massiv[j];
                        massiv[j] = massiv[i];
                        massiv[i] = temp;
                    }
                }
            }
            foreach(int s in massiv){
                Console.WriteLine(s);
            }
        }
    }
}
