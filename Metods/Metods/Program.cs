using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Способы передачи параметров: по значению, по ссылке "ref", возвращаемое значение "out".
            // при передаче параметров по значению, происходит КОПИРОВАНИЕ значения переменной и помещение  
            // их в стек (метод), т.е. в методе main переменные x и y не изменяются, но могут меняться внутри метода.
            int x = 55;
            int y = 10;
            int z = Summa0(x, y); // метод Summa0 вытягивает копии этих значений из стека, складывает и возвращает результат через стек  
            Console.WriteLine(z);
            // передача параметров по ссылке "ref", происходит передача адреса исходной переменной, 
            // и в методе можно изменить значение исходной переменной  
            int f = 15;
            int g = 25;
            int h = SummaRef(ref f, g);
            Console.WriteLine(h);
            // возвращаемое значение, результат возвращается не через оператор return, а через выходной параметр - "out"
            int s; // переменную s не инициализируем
            SummaOut(x,y, out s); // переменная s инициализируется в методе
            Console.WriteLine(s);

            //Виды парметров:
            // значения по умолчанию
            int c = SummaDefault(26);
            int v = SummaDefault2(x:45, z:15);
            // передача переменного списка параметров, значения передаются в массив + ключевое слово "params"
            int b = SummaVariableList(15,25,35,21,89);
            Console.WriteLine(b);
        }
        static int Summa0(int x, int y)
        {
            return x + y;
        }
        static void SummaOut(int x, int y, out int s) // можно создать несколько возвращаемых значений, return возвращает только одно значение
        {
           s = x + y;
        }
        static int SummaRef(ref int f, int g)
        {
            f++;
            return f + g;
        }
        static int SummaDefault(int x, int y = 55)
        {
            return x + y;
        }
        // если заданы несколько параметров по умолчанию, 
        // но нужно изменить значения некоторых, то явно указываем их значения - z:15
        static int SummaDefault2(int x, int y = 55, int z = 21)
        {
            return x + y + z;
        }
        // передача переменного списка параметров, значения передаются в массив + ключевое слово "params"
        static int SummaVariableList(params int[] a)
        {
            int temp = 0;
            foreach (int s in a)
            {
                temp = temp + s;
            };
            return temp;
        }
    }
}
