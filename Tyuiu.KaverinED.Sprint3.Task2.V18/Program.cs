using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task2.V18.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 14);
            Console.WriteLine(res.ToString("0.000"));
            Console.ReadLine();
        }
    }
}
