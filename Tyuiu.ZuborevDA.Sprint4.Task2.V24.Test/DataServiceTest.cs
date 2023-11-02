using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint4.Task2.V24.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 7, 5, 4, 7, 8, 5, 6, 8, 5, 5, 7, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 41;

            Assert.AreEqual(wait, res);
        }
    }
}
