using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint4.Task7.V7.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];

            string value = "31415926";

            Console.Title = "Спринт #4 | Выполнила: Чепурных С. Р. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Чепурных С. Р. | ИСТНб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '31415926'. Преобразуйте              *");
            Console.WriteLine("* ее в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);

            Console.WriteLine("Количество нечётных чисел в матрице = " + result);
            Console.ReadKey();
        }
    }
}
