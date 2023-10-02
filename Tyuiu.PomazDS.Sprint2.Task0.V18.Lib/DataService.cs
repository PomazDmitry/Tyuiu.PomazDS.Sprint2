using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] compareArray = new bool[6];
            compareArray[0] = x == y;
            compareArray[1] = x != y;
            compareArray[2] = y < x;
            compareArray[3] = x > y;
            compareArray[4] = y <= x;
            compareArray[5] = y >= x;
            return compareArray;
        }
    }
}
