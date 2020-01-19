using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znak_na_cialo_chislo
{
    class Program
    {
        static void PrintSign(int number)
        {
            if (number > 0)
                Console.WriteLine("The number {0} is positive", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative.", number);
            else
                Console.WriteLine("The number {0} is zero.", number);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete chislo");
            int d = int.Parse(Console.ReadLine());
            PrintSign(d);
        }
    }
}
