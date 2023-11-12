using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint4.Task6.V7.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint4.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Экономика" };
            int res = ds.Calculate(week);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
