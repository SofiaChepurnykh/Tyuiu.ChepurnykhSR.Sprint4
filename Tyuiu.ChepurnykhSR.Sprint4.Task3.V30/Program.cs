using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint4.Task3.V30.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнила: Чепурных С.Р. | ИСТНб-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #3                                                                           *");
            Console.WriteLine("* Вариант #30                                                                          *");
            Console.WriteLine("* Выполнила: Чепурных С.Р. | ИСТНб-23-1                                                *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими        *");
            Console.WriteLine("* значениями в диапазоне от 1 до 6. Найдите максимальный элемент                       *");
            Console.WriteLine("* в третьей строке массива.                                                            *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");




            int[,] arr =
            {
                {2,4,3,5,1 },
                {6,6,1,2,6 },
                {3,3,2,1,5 },
                {6,4,1,3,3 },
                {5,1,1,6,4 }
            };


            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Максимальный элемент в 3 строке массива = " + ds.Calculate(arr));

            Console.ReadLine();
        }
    }
}
