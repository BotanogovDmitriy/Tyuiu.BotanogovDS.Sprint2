using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint2.Task6.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        { 
            DataService ds = new DataService();
            Assert.AreEqual("4.10", ds.FindDateOfPreviousDay(10, 5));
        }
    }
}
