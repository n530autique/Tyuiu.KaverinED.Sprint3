using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaverinED.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int res = -1;
            int counter = 0;
            foreach (char m in value) { }
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i - 1] == item)
                {
                    counter++;
                }
                else
                {
                    res = counter > res ? counter : res;
                    counter = 0;
                }
            }
            
            return res;
        }
    }
}

