using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4taskk
{
    internal class Program
    {
        //Задача 4. Найти максимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов. 
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Func(a, b, c));

            Console.ReadKey();
        }
        static double Func(int a, int b, int c)
        {
            //вариант с тернарной операцией
            int result = a > c && a > b ? a : b > c && b > a ? b : c;
            return result;

            //2 вариант
            //return Math.Max(Math.Max(a, b), c);
        }
    }
}
