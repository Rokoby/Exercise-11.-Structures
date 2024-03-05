using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Значение k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Linear linear = new Linear(k,b) ;
            Console.WriteLine(linear.Root());
            Console.ReadKey();
        }
    }
}
