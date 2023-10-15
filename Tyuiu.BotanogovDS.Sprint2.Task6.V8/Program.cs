using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint2.Task6.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                res = "Введены не верные значения";

            }
            else
            {
                res = "Предыдущая дата: " + ds.FindDateOfPreviousDay(m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}