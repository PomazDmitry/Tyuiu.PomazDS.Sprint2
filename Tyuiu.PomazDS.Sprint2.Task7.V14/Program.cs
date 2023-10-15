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

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        }
    }
}
