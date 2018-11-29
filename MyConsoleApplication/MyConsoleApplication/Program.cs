using System;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            
            /*Color c = Color.blue;
            Color d = Color.white;
            int i = (int)c + (int)d;
            Console.WriteLine(i);

            Mystruct s;
            s.Name = "Имя Ram";
            s.Age = 23;
            s.Phone = 12346;
            Console.WriteLine(s.Name + " " + s.Age + "г" + " " + "тел." + s.Phone);*/
        }
    }

    struct Mystruct
    {
        public string Name;
        public int Age;
        public int Phone; 
    }
    enum Color
    {
        red=52,
        blue=23,
        white=45,
        black=78,
        green=00
    } 
}
