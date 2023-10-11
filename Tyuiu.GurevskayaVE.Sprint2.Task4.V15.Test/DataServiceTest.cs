using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint2.Task4.V15.Lib;

namespace Tyuiu.GurevskayaVE.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 83.7;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculate2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 576;
            double res = ds.Calculate(x, y);
            double wait = 0.286;
            Assert.AreEqual(wait, res);
        }
    }
}
