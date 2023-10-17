using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task0.V18.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = Math.Round(ds.GetSumSeries(1, 6), 3);
            double wait = 914700.94;
            Assert.AreEqual(wait, res);
        }
    }
}
