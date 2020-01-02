using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Делене_на_цели_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavdete chislo");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n ; i++)
            { 
                Console.WriteLine("Vavdete chislo");
                int chislo = int.Parse(Console.ReadLine());
                      Console.WriteLine("Vavdete chislo next");
                    int newchislo = int.Parse(Console.ReadLine());
                       int  d = chislo % newchislo;
                    Console.WriteLine("   Ostatakat e:" + d);
                    s = s + d;
                }
                 Console.WriteLine("Sumata ot ostatacite e:"+s);
        }
    }
}
    

