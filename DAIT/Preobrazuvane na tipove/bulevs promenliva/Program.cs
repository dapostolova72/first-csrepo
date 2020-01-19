using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulevs_promenliva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete niz");
            string duma = Console.ReadLine();
            bool newduma = Convert.ToBoolean(duma);
            if (newduma == true)
            { Console.WriteLine("Yes"); }
            else
            {
                Console.WriteLine("No");

            }

        }
    }
}
