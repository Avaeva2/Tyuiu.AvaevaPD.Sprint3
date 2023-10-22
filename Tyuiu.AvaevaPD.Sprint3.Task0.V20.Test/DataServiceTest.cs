using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint3.Task0.V20.Lib;

namespace Tyuiu.AvaevaPD.Sprint3.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = 1;
            char item = 14;
           

            double res = ds.GetCharCount(value, item);

            double wait = 0.555927;

            Assert.AreEqual(wait, res);
        }
    }
}