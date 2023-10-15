using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint2.Task4.V9.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = -3;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -5;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 7.04;
            Assert.AreEqual(wait, res);
        }
    }
}
