using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5task
{
    internal class Program
    {
        //Задача 5. Найти s=max(a, b) + max(c, d), используя вспомогательную функцию (метод).

        //вариант с 4 переменными
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    Console.Write("d=");
        //    int d = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"s={Func(a, b, c, d)}");

        //    Console.ReadKey();
        //}
        //static double Func(int a, int b, int c, int d)
        //{
        //    int block1 = a > b ? a : b;
        //    int block2 = c > d ? c : d;
        //    return block1 + block2;
        //    //2 вариант
        //    //return Math.Max(a, b) + Math.Max(c, d);
        //}

        //вариант с 2 переменными
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"sum={Func(a, b) + Func(a, b)}");

            Console.ReadKey();
        }
        static double Func(int a, int b)
        {
            int result = a > b ? a : b;
            return result;
        }
    }
}
