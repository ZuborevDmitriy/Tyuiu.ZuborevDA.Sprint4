using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZuborevDA.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            for (int i = 3; i <= array.Length - 5; i++)
            {
                if (array[i] % 2 != 0)
                {
                    mult *= array[i];
                }
            }
            return mult;
        }
    }
}
