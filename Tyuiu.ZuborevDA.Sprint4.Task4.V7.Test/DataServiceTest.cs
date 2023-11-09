using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint4.Task4.V7.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {{4,3,6,5,5},
                                         {3,4,4,6,4},
                                         {6,4,6,4,5},
                                         {5,4,4,4,5},
                                         {3,5,6,4,6}};
            int res = ds.Calculate(mas2);
            int wait = 39;

            Assert.AreEqual(wait, res);
        }
    }
}
