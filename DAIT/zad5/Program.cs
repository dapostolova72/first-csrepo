using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            //top row
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //middle row
            for (int rows = 0; rows < n - 2; rows++)
            {
                Console.Write("|");
                for (int a = 0; a < n - 2; a++)
                    Console.Write(" -");
                Console.WriteLine(" |");
            }
            //bottom row 
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
    }
