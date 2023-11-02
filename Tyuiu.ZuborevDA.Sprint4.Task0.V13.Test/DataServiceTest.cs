using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint4.Task0.V18.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray = 18;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
