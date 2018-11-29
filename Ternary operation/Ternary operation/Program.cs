using System;

namespace Ternary_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
            Console.WriteLine("нажмите + ил -");
            string s = Console.ReadLine();
            int z = s == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
            /*s == "+" ? - первый операнд + условие, если условие истина то выполняется второй операнд, 
             * если лож то трей операнд, (x + y) - 2-й операнд : (x - y) - 3-й операнд;*/
        }
    }
}
