using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverka_za_chislo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete chislo");
            double chislo = double.Parse(Console.ReadLine());

            if ((Math.Ceiling(chislo)-chislo)>0 )

            {
                Console.WriteLine("1integer");
                Console.WriteLine(chislo % 2);
                Console.WriteLine(chislo % 1);
            }
            else
            {
                Console.WriteLine("2floating-point");
                Console.WriteLine(chislo % 2);
                Console.WriteLine(chislo % 1);
            }
        }
    }

}

