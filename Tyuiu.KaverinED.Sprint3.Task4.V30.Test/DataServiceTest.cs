using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidEXpression()
        {
            DataService ds = new DataService();
            double wait = 0.962 + 0.962;
            double res = ds.Calculate(-5, 5);
            Assert.AreEqual(wait, res);
        }
    }
}
