using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task5.V1.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double wait = 6.29950947323482869315886869777;
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            wait = Math.Round(wait, 3);
            res = Math.Round(res, 3);
            Assert.AreEqual(wait, res);
        }
    }
}
