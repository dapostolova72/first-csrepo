using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Квадрат_от_звездички
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete broj redove i koloniN=");
            int n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
               
                for (var col = 1; col <= n; col++)

               {
                   Console.Write("*");
                    Console.Write(" ");

                }
                Console.WriteLine();

            }

           


        }
    }
}
