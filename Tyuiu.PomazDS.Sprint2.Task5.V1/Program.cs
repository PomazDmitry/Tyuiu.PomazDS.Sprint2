using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint2.Task5.V1.Lib;
using AutoFill_lib;

namespace Tyuiu.PomazDS.Sprint2.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            ptrn.MainPattern("Оператор switch", 5, 1, "Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат. Условие: По данному номеру месяца, определите количество дней в этом месяце.");

            Console.WriteLine("Введите номер месяца: ");
            int value = int.Parse(Console.ReadLine());

            ptrn.ResultPattern();

            Console.WriteLine(ds.FindMonthDaysCount(value));

            Console.ReadKey();
        }
    }
}
