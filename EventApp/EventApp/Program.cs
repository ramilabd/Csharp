using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(500);
            acc.Added += Show_Message;
            acc.Withdrawn += Show_Message;

            acc.Put(300);
        }

        public static void Show_Message(object sender, AccountEventArgs e)
        {
            Console.WriteLine("Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message, e.Sum);
        }
    }
}
