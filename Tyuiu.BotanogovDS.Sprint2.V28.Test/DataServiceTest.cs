using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint2.V28.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService(); 
            int x = 111;
            int y = 735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, false, false, false, false };
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}
