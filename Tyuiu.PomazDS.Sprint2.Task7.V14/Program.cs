using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint2.Task7.V14.Lib;
using AutoFill_lib;

namespace Tyuiu.PomazDS.Sprint2.Task7.V14

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            AutoFill ptrn = new AutoFill();
            ptrn.MainPattern("Добавление к решению итоговых проектов по спринту", 7, 14, "Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            ptrn.ResultPattern();
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        }
    }
}
