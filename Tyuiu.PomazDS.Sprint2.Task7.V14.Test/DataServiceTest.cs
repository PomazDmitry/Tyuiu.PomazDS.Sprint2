using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint2.Task7.V14.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            bool result = ds.CheckDotInShadedArea(x,y);
            Assert.AreEqual (true,result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.5;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 0.5;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, result);
        }
    }
}
