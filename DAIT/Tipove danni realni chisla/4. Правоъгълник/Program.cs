using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Правоъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete stranata a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete stranata b");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            double p = 2 * a + 2 * b;
            double diag = Math.Sqrt(a * a + b * b);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(diag);
        }
    }
}
