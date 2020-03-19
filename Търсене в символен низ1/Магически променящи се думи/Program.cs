using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магически_променящи_се_думи
{
    class Program
    {

        static bool magicnumbers(string duma1, string duma2)
        {
          
            char[] duma11 = duma1.Distinct().ToArray();
            Console.WriteLine(duma1.Distinct().ToArray());

         
            char[] duma22 = duma2.Distinct().ToArray();
            Console.WriteLine(duma2.Distinct().ToArray());
            
                bool da = true;

            if (duma11.Length == duma22.Length)
            {

                da = true;


            }
            else
            {
                da = false;

            }
                return da;
        }
        static void Main(string[] args)
        {   Console.WriteLine("Vavedete parvata duma");
            string duma1 = Console.ReadLine();
            Console.WriteLine("Vavedete vtorata duma");
            string duma2 = Console.ReadLine();

            Console.WriteLine(magicnumbers(duma1, duma2));
           


        } } }



