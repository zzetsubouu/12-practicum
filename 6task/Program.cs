using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6task
{
    internal class Program
    {
        //Задача 6. Вывести дни недели в зависимости от номера дня с использованием вспомогательного метода.
        static void Main(string[] args)
        {
            Console.Write("введите номер дня недели: ");
            int day = int.Parse(Console.ReadLine());
            DayOfWeek(day);
            Console.ReadKey();
        }
        static void DayOfWeek(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("понедельник"); break;
                case 2: Console.WriteLine("вторник"); break;
                case 3: Console.WriteLine("среда"); break;
                case 4: Console.WriteLine("четверг"); break;
                case 5: Console.WriteLine("пятница"); break;
                case 6: Console.WriteLine("суббота"); break;
                case 7: Console.WriteLine("воскресенье"); break;
                default: Console.WriteLine("введен номер не от 1 до 7"); break;
            }
        }
    }
}
