using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PomazDS.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] compareArray = new bool[6];
            compareArray[0] = (a < b) | (c > d);
            compareArray[1] = (a > b) & (c < d);
            compareArray[2] = (a > b) || (c < d);
            compareArray[3] = (a > b) && (c < d);
            compareArray[4] = !compareArray[0];
            compareArray[5] = (a > b) ^ (c != d);
            return compareArray;
        }
    }
}
