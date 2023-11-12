using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint4.Task5.V15.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] numsArray = new int[,] { {0, -4, 2, -4, 3},
                                            {-5, -3, 2, -4, -2},
                                            {3, -2, -3, -1, 2},
                                            {-3, -3, -1, -1, 1},
                                            {-5, -2, -5, -1, 1}};
            int res = dataService.Calculate(numsArray), wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
