using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task4.V3.Lib
{
    public class DataService : ISprint2Task4V3
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x < y - 1 ? y + (y - 1) / (x + 2) : x + 2 * y * (1 / (y + 3)), 3);
        }
    }
}
