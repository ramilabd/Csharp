using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstAcquaintance.GetGreetingMessage("Student", 10.01));
            Console.WriteLine(FirstAcquaintance.GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(FirstAcquaintance.GetGreetingMessage("Steve Jobs", 1));
        }
    }
}
