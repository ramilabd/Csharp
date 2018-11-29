using System;

namespace SummaNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            // алгоритм сложения всех цифр составляющих заданное число, используюя рекрсию метода
            int n = 10;
            int res = summa2(n);
            Console.WriteLine(res);
        }
        static int summa2(int n)
        {
            if (n == 1) return 1;
            return n + summa2(n - 1); // рекурсия метода
        }
    }
}
