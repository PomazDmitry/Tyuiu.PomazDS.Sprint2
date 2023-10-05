using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint2.Task4.V3.Lib;
using AutoFill_lib;

namespace Tyuiu.PomazDS.Sprint2.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            ptrn.MainPattern("Тернарный оператор", 4, 3, "Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, где пользователь вводит значение переменных х,у с клавиатуры, если х < у - 1, то z = (y - 1) / (x + 2) иначе x + 2y * (1 / (y + 3))");

            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            ptrn.ResultPattern();

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
