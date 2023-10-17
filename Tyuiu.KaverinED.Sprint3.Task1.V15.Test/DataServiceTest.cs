using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task1.V15.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(2, 1, 5);
            double wait = 208845.0;
            Assert.AreEqual(res.ToString("0.000"), wait.ToString("0.000"));
        }
    }
}
