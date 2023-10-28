using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AvaevaPD.Sprint3.Task3.V17.Lib;
namespace Tyuiu.AvaevaPD.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "*vn98n!b";
            char c = '8';
            double res = ds.ConvertStringToInt(str);

            int wait = 2;

            Assert.AreEqual(wait, res);


        }
    }
}
