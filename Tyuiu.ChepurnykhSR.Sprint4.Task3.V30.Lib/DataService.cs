using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int res = int.MinValue;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                res = Math.Max(array[2, i], res);
            }
            return res;
        }
    }
}
