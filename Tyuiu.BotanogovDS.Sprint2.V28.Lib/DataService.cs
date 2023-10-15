using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotanogovDS.Sprint2.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {

        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == y;  
            result[1] = x + 624 != y;
            result[2] = x + 626 < y; 
            result[3] = x > y;
            result[4] = x + 626 <= y;  
            result[5] = x >= y; 

            return result; 
        }
    }
}
