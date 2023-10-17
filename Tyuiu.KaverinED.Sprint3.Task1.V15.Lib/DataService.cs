using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaverinED.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            stopValue++;

            while (startValue != stopValue)
            {
                res *= (value * value * startValue) + 1;
                startValue++;
            }
            return res;
        }
    }
}
