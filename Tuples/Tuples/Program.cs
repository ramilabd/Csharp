using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 10
            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1); // 31
            Console.Read();

        }
    }
}
