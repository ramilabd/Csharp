using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Ternary
    {
        int x;
        int y;
        public Ternary(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }
                
        public void metodTernary()
        {
            Console.WriteLine("начальные данные х = {0}, у = {1}", x, y);
            Console.WriteLine("нажмите + или -");

            string selection = Console.ReadLine();
            int z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
        } 
    }
}
