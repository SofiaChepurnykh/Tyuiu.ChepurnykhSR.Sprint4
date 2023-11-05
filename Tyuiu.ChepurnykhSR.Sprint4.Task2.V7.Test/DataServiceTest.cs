using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint4.Task2.V7.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };

            int wait = 30, res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
