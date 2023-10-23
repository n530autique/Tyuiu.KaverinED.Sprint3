using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaverinED.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
        }
    }
}
