using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint2.Task1.V15.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Помаз Д.С. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил Помаз Д.С. | ИИПб-23-2                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать но использовать один раз в выражении*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций  *");
            Console.WriteLine("* не должна нарушаться), а также арифметических выражений, которая вернет *");
            Console.WriteLine("* логическую последовательность(массив):                                  *");
            Console.WriteLine("* (True, False, False, False, False, True)                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* a = 415, b = 616, c = 134, d = 127                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int a = 415, b = 616, c = 134, d = 127;
            bool[] compareArray = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(compareArray[i]);
            }

            Console.ReadKey();
        }
    }
}
