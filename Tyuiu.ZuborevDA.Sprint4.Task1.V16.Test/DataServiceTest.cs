using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 1323;

            Assert.AreEqual(wait, res);
        }
    }
}
