using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZuborevDA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.ZuborevDA.Sprint4.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #8                                                                 *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 264795863157. Преобразуйте ее в          *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                         *");

            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];

            string str = "264795863157";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* СУММА НЕЧЕТНЫХ ЧИСЕЛ РАВНА:                                                *");
            Console.WriteLine("******************************************************************************");

            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
