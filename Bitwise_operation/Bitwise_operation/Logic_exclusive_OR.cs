using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_operation
{
    class Logic_exclusive_OR
    {
        public void Encrypring()
        {
            Console.WriteLine("Введите шифруемое число");
            int sourse = int.Parse(Console.ReadLine());
            int key = 15;
            int encryption = sourse ^ key;
            Console.WriteLine($"Зашифрованное число - {sourse}");
            Console.WriteLine($"Шифровка - {encryption}");
            int discryption = encryption ^ key;
            Console.WriteLine($"Расшифрованное число - {discryption}");
        }
    }
}
