using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint2.Task4.V9.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                      ");
            Console.WriteLine("***********************************************************************");
            
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double res = ds.Calculate(x, y);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            ");
            Console.WriteLine("***********************************************************************");
            
            Console.WriteLine("Значение функции " + res);
            
            Console.ReadKey();
        }
    }
}
