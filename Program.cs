using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        public static double F(int x)
        {
            return Math.Sqrt(x) + x / 2;
        }
        static void Main(string[] args)
        {
            //Задача 1.Вычислить значение выражения,
            //определив и использовав дополнительный метод:
            double y = F(5) + F(12) + F(19);
            Console.WriteLine($"y={y}");
            Console.Read();
        }
    }
}
