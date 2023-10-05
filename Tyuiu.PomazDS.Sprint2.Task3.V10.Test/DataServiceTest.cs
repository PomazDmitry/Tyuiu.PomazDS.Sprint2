using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint2.Task3.V10.Lib;

namespace Tyuiu.PomazDS.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(6.333, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(-1, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.25, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -16;
            double res = ds.Calculate(x);
            Assert.AreEqual(-175.938, res);
        }
    }
}
