using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
