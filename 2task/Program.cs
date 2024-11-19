using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2task
{
    internal class Program
    {
        //Задача 2. Вычислить значение выражения, определив и использовав дополнительный метод:
        static void Main(string[] args)
        {
            double y = Func(5, 7) + Func(12, 8) + Func(19, 2);
            Console.WriteLine($"y={y}");
            Console.ReadKey();
        }
        static double Func(int x1, int x2)
        {
            return (Math.Sqrt(x1) + x1) / Math.Sqrt(x2) + x2;
        }
    }
}
