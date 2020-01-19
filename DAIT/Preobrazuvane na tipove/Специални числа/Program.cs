using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Специални_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete chislo");
            int n = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <=n; i++)
            {                
                double s = 0;
                int d = i;
                while (d > 0)
                {
                    double pn = d % 10;                                  
                     s = s +pn ;
                   d = d / 10;
                }
                bool special = (s == 5) || (s == 7) || (s == 11);
                Console.WriteLine("{0} -> {1}", i, special);


            }




        }
        }
    }

