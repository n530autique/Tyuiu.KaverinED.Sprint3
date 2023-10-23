using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            double[] res = ds.GetMassFunction(-5, 5);
            for (int i = 0; i != res.Length; i++)
            {
                Console.WriteLine($"{i + startValue} | {res[i]}");
                Console.WriteLine("——————");
            }
            Console.ReadLine();
        }
    }
}
