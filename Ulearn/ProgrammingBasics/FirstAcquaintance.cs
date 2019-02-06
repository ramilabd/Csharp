using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    class FirstAcquaintance
    {
        public static string GetGreetingMessage(string name, double salary)
        {
            return $"Hello, {name}, your salary is {Math.Ceiling(salary)}";
        }
    }
}
