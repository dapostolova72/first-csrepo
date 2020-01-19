using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepenuvane_na_chislo
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(   RaiseToPower(2, 10));
        }
    }
}
