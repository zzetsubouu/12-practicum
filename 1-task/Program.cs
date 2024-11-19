using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_task
{
    internal class Program
    {
        //Задача 1. Вычислить значение выражения, определив и использовав дополнительный метод:

        static void Main(string[] args)
        {
            double y = Func(6) + Func(13) + Func(21);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        static double Func(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }
    }
}
