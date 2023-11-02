using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZuborevDA.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; //кол-во строк
            int columns = array.Length / rows;    //кол-во столбцов

            int sum = 0;

                for(int i = 0; i < columns; i++)
                {
                        sum += array[i,2];
                }

            return sum;
        }
    }
}
