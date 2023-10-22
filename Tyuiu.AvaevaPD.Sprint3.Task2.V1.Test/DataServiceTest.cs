﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint3.Task2.V1.Lib;
namespace Tyuiu.AvaevaPD.Sprint3.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 56.552;

            Assert.AreEqual(wait, res);
        }
    }
}
