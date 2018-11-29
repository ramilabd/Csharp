using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int sourse = 50;
            int key = 15;
            int encryption = sourse ^ key;
            Console.WriteLine($"Зашифрованное число - {sourse}");
            Console.WriteLine($"Шифровка - {encryption}");
            int discryption = encryption ^ key;
            Console.WriteLine($"Расшифрованное число - {discryption}");

        }
    }
}
