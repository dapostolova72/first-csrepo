using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace асансьор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko choveka shte polzvat asansura:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" Za kolko choveka e prednaznachen  asansura:");
            int p = int.Parse(Console.ReadLine());
            double kursove = Math.Ceiling((double)n / p);
            Console.WriteLine(" Shte sa nujni "+kursove+"kursa");

        }
    }
}
