using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint4.Task4.V7.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #7                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями*");
            Console.WriteLine("* с клавиатуры в диапазоне от 3 до 6. Найдите сумму нечетных элементов       *");
            Console.WriteLine("* массива.                4, 3, 6, 5, 5,                                     *");
            Console.WriteLine("*                         3, 4, 4, 6, 4,                                     *");
            Console.WriteLine("*                         6, 4, 6, 4, 5,                                     *");
            Console.WriteLine("*                         5, 4, 4, 4, 5,                                     *");
            Console.WriteLine("*                         3, 5, 6, 4, 6,                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("******************************************************************************");

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* СУММА НЕЧЕТНЫХ ЭЛЕМЕНТОВ МАССИВА РАВНА:                                    *");
            Console.WriteLine("******************************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
