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

            int[] numsArray = { 8, 9, 7, 1, 5, 6, 3, 2, 4, 3, 6, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 11;

            Assert.AreEqual(wait, res);
        }
    }
}
