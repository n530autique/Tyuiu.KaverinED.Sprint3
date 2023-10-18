using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task2.V18.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double test = ds.GetMultiplySeries(1, 1, 14);
            double wait = 287.180137924795;
            Assert.AreEqual(test.ToString("0.000"), wait.ToString("0.000"));
        }
    }
}
