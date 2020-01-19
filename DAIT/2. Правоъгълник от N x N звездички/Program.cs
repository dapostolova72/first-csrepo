using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Правоъгълник_от_N_x_N_звездички
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Vavedete broj redove i koloniN=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n));

            }
        }
    }
}
