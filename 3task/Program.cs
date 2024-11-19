using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3task
{
    internal class Program
    {
        //Задача 3. Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Func(a, b));
            Console.ReadKey();
        }
        static double Func(int a, int b)
        {
            //вариант с тернарной операцией
            int result = a > b ? a : b;
            return result;
            
            //2 вариант
            //return Math.Max(a, b);
        }
    }
}
