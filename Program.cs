using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12._2
{
    class Program
    {
        public static double F1(int x)
        {
            return Math.Sqrt(x) + x; 
        }
        public static double F2(int y)
        {
            return Math.Sqrt(y) + y;
        }



        static void Main(string[] args)
        {
            //Задача 2.Вычислить значение выражения, 
            //определив и использовав дополнительный метод:
            double x = F1(5) / F2(7) + F1(12) / F2(8) + F1(19) / F2(2);
            Console.WriteLine($"x={x}");
            Console.Read();
        }
    }
}
