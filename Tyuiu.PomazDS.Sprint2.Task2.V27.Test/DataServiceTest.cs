using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint2.Task2.V27.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 6;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
