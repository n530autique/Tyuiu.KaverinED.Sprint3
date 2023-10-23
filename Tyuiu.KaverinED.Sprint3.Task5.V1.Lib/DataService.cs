using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaverinED.Sprint3.Task5.V1.Lib
{
    public class DataService : ISprint3Task5V1
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res1 = 0, res2 = 0;
            for (int j = startValue2; j != stopValue2 + 1; j++)
            {
                res1 += 1 / (Math.Cos(j) + x);
            }
            for (int i = startValue1; i != stopValue1 + 1; i++)
            {
                res2 += res1;
            }
            return res2;
        }
    }
}
