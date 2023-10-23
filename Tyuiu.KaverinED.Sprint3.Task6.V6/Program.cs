using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KaverinED.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine(ds.GetSumTheDivisors(16, 24));
            Console.ReadKey();
        }
    }
}
