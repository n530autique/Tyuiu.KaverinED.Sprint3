using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task1.V15.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каверин ЕД ИИПБ-23-3");
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(2, 1, 5);
            string stringRes = res.ToString("0.000");
            Console.WriteLine(stringRes);
            Console.ReadLine();
        }
    }
}
