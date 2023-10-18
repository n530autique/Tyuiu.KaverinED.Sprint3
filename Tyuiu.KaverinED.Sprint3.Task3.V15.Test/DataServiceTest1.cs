using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task3.V15.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.GetMinCharCount("lrmmse mg sermmmrt", 'm');
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
