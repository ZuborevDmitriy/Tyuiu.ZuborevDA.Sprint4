using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint4.Task5.V8.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {{-3,1,2,3,4},
                                         {0,4,1,-2,2},
                                         {-1,3,1,3,3},
                                         {2,-1,0,4,1},
                                         {-2,3,2,1,4}};
            int[,] res = ds.Calculate(mas2);
            int[,] waitArray ={{0,1,2,3,4},
                               {0,4,1,0,2},
                               {0,3,1,3,3},
                               {2,0,0,4,1},
                               {0,3,2,1,4}};

            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}
