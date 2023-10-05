using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round(x - Math.Pow((x + 15) / (x - 4), x), 3);
            }
            else if (x == 0)
            {
                return Math.Round((Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2), 3);
            }
            else if (-14 < x && x < 0)
            {
                double pow = Math.Pow(x, 2);
                pow *= -1;
                return Math.Round(Math.Pow(5.0 + (1.0 / pow), x), 3);
            }
            else
            {
                return Math.Round(x + 10 * x - (1 / x), 3);
            }

        }
    }
}
