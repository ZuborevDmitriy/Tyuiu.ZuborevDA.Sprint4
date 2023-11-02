using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                              *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #16                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный значениями *");
            Console.WriteLine("* с клавиатуры в диапазоне от 3 до 8 подсчитать произведение нечетных        *");
            Console.WriteLine("* элементов массива. С клавиатуры: 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4     *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЙ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine($"Введите значение {i} элемента массива:");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ПРОИЗВЕДЕНИЕ НЕЧЕТНЫХ ЭЛЕМЕНТОВ МАССИВА:                                   *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(numsArry);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
