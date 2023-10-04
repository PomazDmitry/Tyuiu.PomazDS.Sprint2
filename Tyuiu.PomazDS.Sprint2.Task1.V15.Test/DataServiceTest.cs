using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint2.Task1.V15.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 3, b = 4, c = 2, d = 1;
            bool[] compareArray = ds.GetLogicOperations(a,b,c,d);
            bool[] res = { true, false, false, false, false, true };
            CollectionAssert.AreEqual(res, compareArray);
        }
    }
}
