using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
                double bp1 = 0.00;
                double bp2 = 0.00;
                double bp3 = 0.00;
                
                double br = 0.00;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Vavedete chislo");
                  double  chislo = int.Parse(Console.ReadLine());
                    br++;
                    if (chislo %2==0)
                    { bp1 += 1; }
                    
                    if (chislo %3==0)
                    { bp2 += 1; }
                    
                    if (chislo %4==0)
                    { bp3 += 1; }
                   

                }

                Console.WriteLine("{0:0.00}%", 100 * bp1 / br);
                Console.WriteLine("{0:0.00}%", 100 * bp2 / br);
                Console.WriteLine("{0:0.00}%", 100 * bp3 / br);
               



            }
        }
    }

