using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasova_belejka
{
    class Program
    {
        static void PrintHeader()
        { Console.WriteLine("CASH RECEPT");
            Console.WriteLine("................");
        }
        static void PrintBody()
        {
            Console.WriteLine("CASH RECEPT");
            Console.WriteLine("................");
        }
        static void PrintFooter()
        {
            Console.WriteLine("CASH RECEPT");
            Console.WriteLine('\u00A9'+" SoftUni" );
        }

            private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
