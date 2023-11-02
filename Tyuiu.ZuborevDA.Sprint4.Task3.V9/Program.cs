using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint4.Task3.V9.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                                *");
            Console.WriteLine("* Задание #3                                                                 *");
            Console.WriteLine("* Вариант #9                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный           *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9. Найдите сумму элементов во  *");
            Console.WriteLine("* втором столбце массива. 9, 6, 4, 5, 3,                                     *");
            Console.WriteLine("*                         7, 4, 7, 5, 3,                                     *");
            Console.WriteLine("*                         8, 5, 9, 9, 3,                                     *");
            Console.WriteLine("*                         7, 8, 7, 9, 3,                                     *");
            Console.WriteLine("*                         3, 7, 3, 7, 7,                                     *");

            int[,] arry = new int[5, 5] {{9, 6, 4, 5, 3},
                                         {7, 4, 7, 5, 3},
                                         {8, 5, 9, 9, 3},
                                         {7, 8, 7, 9, 3},
                                         {3, 7, 3, 7, 7}};
            int rows = arry.GetUpperBound(0) + 1;
            int columns = arry.Length / rows;

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arry[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* СУММА ЭЛЕМЕНТОВ ВТОРОГО СТОЛБЦА РАВНА:                                     *");
            Console.WriteLine("******************************************************************************");
            int res = ds.Calculate(arry);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
