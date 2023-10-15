using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y <= x && (x > 0) && (x <= 1) && (y > 0) && (y <= 1))
            {
                return true;
            }
            else if (y <= -x && (x > 0) && (x <= 1) && (y < 0) && (y >= -1))
            {
                return true;
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && (x < 0) && (x >= -1) && (y > 0) && (y <= 1))
            {
                return true;
            }
            else return false;
        }
    }
}
