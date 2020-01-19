using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverka_na_chislo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("vavedete chislo");
               int  chislo = int.Parse(Console.ReadLine());

                if (chislo % 2 != 0 || chislo % 2 != 1)

                {
                    Console.WriteLine("integer");
                  
                }
            }
            catch
            {
                Console.WriteLine("floating-poit");
            }

        }
    }
}
