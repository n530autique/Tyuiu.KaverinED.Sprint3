using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaverinED.Sprint3.Task4.V30.Lib
{

    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i != stopValue + 1; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                res += Math.Sin(i) / Convert.ToDouble(i);
            }
            return Math.Round(res, 3);
        }
    }
}
