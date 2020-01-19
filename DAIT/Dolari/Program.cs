using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete broj redove i koloniN=");
            int n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {

                for (var col = 1; col <= row; col++)

                {
                    Console.Write("$");
                    Console.Write(" ");

                }
                Console.WriteLine();

            }

        }
    }
}
