using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preobrazuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete godini");
            string a = Console.ReadLine();
          
          
            Console.WriteLine("Vavedete duma");
            string b = (Console.ReadLine());
          
             if (a[0] < b[0])
             { Console.WriteLine(a); }
             else
            {
                Console.WriteLine(b);
             }
        }
    }
}
