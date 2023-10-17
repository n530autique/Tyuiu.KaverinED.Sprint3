using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KaverinED.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 1;
            stopValue++;
            
            for (int i = startValue; i < stopValue; i++)
            {
                res *= Math.Pow((2 / (Math.Cos(1) + 0.5)), i);
            }
            return Math.Round(res, 3);
        }
    }
}
