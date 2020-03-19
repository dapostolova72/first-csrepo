using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    { static bool Palindrom(string duma)
        {
           
            string duma2 = "";
            bool da = duma==duma2;
            for (int i = duma.Length - 1; i >= 0; i--)
            {
                duma2 = duma2 + duma[i];

            }
           
            if (duma == duma2)
            { da = true; }
            else
            { da=false; }

            return da;


        }
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();

            Console.WriteLine(  Palindrom(duma));


        }
    }
}
