using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(16, 24);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
