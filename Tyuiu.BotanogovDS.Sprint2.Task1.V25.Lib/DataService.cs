using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotanogovDS.Sprint2.Task1.V25.Lib
{
    public class DataService : ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a == 247) | (b != 155);
            result[1] = (c < d) & !(a > b);
            result[2] = (d >= c) || (b < a);
            result[3] = !(a <= b) && !(d > c);
            result[4] = (c == 325) ^ (d != 857);
            result[5] = !(b + 93 >= a); 

            return result;
        }
    }
}
