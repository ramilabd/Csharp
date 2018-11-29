using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 }; // создание одномерного массива
            Console.WriteLine(array[2]); //доступ к элементам массива
            Console.WriteLine(array.Length); //возвращает длину массива

            int[,] mass = { { 1, 2, 3, 4, 5, 6 }, { 11,12,13,14,15, 16} }; // создание двухмерного массива
            Console.WriteLine(mass.Length); //возвращает длину массива
            Console.WriteLine(mass.GetLength(1)); //возвращает длину массива во втором измерении: (1) - индекс измерения
            Console.WriteLine(mass.Rank); // возвращает размерность массива

            int[] copy = array; //копируется не сам массив а ссылка на массив
            Console.WriteLine(copy[2]); //доступ к элементам массива

            int[] array2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            Array.Reverse(array2);  // изменяет порядок следования элементов массива на обратный
            foreach (int n in array2)
            {
                Console.WriteLine(n);
            }

            int[] arraySort = new int[10] { 1, 20, -3, 14, 5, 6, -7, 28, 9, 10 };
            Array.Sort(arraySort); // сортирует элементы массива в порядке увеличения
            foreach(int s in arraySort)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
