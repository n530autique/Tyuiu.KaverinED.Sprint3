using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task0.V18.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каверин ЕД ИИПБ-23-3");
            DataService ds = new DataService();
            Console.WriteLine(ds.GetSumSeries(1, 6));
            Console.ReadLine();
        }
    }
}
