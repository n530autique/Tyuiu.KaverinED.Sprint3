using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaverinED.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            double[] result = new double[stopValue - startValue + 1];
            int index = 0;
            for (int i = startValue; i != stopValue + 1; i++)
            {
                try
                {
                    result[index] = Math.Round((5 * i + 2.5) / (Math.Sin(i) + 3) + (2 * i) + Math.Cos(i), 2);
                }
                catch (DivideByZeroException)
                {
                    result[index] = 0;
                }
                index++;
            }
            return result;
        }
    }
}
