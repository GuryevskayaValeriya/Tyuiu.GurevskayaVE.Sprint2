﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint2.Task7.V4.Lib;

namespace Tyuiu.GurevskayaVE.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check7()
        {
            DataService ds = new DataService();

            double x = 0.4;
            double y = 0.4;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
