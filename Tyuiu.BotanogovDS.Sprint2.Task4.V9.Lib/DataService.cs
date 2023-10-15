using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BotanogovDS.Sprint2.Task4.V9.Lib
{
    public class DataService : ISprint2Task4V9
    {
        public double Calculate(double x, double y)
        {
            double z = x + 5 < y / 2 ? Math.Pow((7 + 1 / (x * x)), y) : x * x * x * x - (3 / y);
            return Math.Round(z, 3);
        }
    }
}
