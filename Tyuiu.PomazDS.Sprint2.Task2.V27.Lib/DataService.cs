using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task2.V27.Lib
{
    public class DataService : ISprint2Task2V27
    {
        public bool CheckDotInShadedArea(int x, int y)
        {

            if (x == 3 && y >= 3 && y <= 6 || (x == 3 && y == 11)) return true;
            else if (x == 4 && y >= 3 && y <= 5 || (x == 4 && y == 11)) return true;
            else if (x == 5 && y >= 3 && y <= 5 || (x == 5 && y == 11)) return true;
            else if (x == 6 && y >= 5 && y <= 11) return true;
            else if (x == 7 && y >= 5 && y <= 8) return true;
            else if (x == 8 && y >= 5 && y <= 8) return true;
            else if (x == 9 && y >= 3 && y <= 12) return true;
            else if (x == 10 && y >= 8 && y <= 13) return true;
            else if (x == 11 && y >= 8 && y <= 13) return true;
            else if (x == 12 && y >= 8 && y <= 13) return true;
            else if (x == 13 && y >= 6 && y <= 8) return true;
            else return false;
        }
    }
}
