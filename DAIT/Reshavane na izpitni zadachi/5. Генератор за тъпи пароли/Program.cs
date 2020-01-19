using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Генератор_за_тъпи_пароли
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
              
             
                    for (char d = (char)097; d < (char)097 + l; d++)



                {
                    Console.Write("{0}{1}{2}{3} ", i, i, d,d);
                    for (int m = 1; m <= n; m++)
                            {

                                if (m > i )
                        {
                            Console.Write(m);

                                   



                                }



                            }
                        }
                    }
                }
            }
        }
    

