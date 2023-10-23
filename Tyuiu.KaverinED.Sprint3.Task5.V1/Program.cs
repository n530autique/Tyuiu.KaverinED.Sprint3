using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task5.V1.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine(ds.GetSumSumSeries(5, 1, 1, 3, 10));
            Console.ReadKey();
        }
    }
}
