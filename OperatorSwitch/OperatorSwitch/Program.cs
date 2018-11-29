using System;

namespace OperatorSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Color s = Color.red;
            switch (s)
            {
                case Color.red:
                    Console.WriteLine("Сработал красный блок");
                    break;
                case Color.white:
                    break;
                case Color.green:
                    Console.WriteLine("Сработал зеленый блок");
                    break;
                case Color.blue:
                    break;
                default:
                    break;
            }
        }
        enum Color
        {
            red = 5,
            white = 8,
            green = 10,
            blue = 1
        }
    }
}
