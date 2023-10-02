using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint2.Task0.V18.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1, y = 2;
            bool[] compareArray = ds.GetCompareOperations(x, y);
            bool[] res = { false, true, false, false, false, true };
            CollectionAssert.AreEqual(res, compareArray);
        }
    }
}
