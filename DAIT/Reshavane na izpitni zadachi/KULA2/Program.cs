using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KULA2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 5)
            {
                Console.Write("/" + new string('^', n / 2) + "\\" + "/" + new string('^', n / 2) + "\\");
                Console.WriteLine();
                for (int i = 1; i <= n - 2; i++)
                { Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|"); }

                Console.Write("\\" + new string('_', n / 2) + "/" + "\\" + new string('_', n / 2) + "/");
            }
            else 
            if (n >= 5)
            {
                Console.Write("/" + new string('^', n / 2) + "\\" + new string('_', n - 4) + "/" + new string('^', n / 2) + "\\");
                Console.WriteLine();
                for (int i = 1; i <= n - 2; i++)
                { Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|"); }

                Console.Write("\\" + new string('_', n / 2) + "/" + new string('-', n - 4) + "\\" + new string('_', n / 2) + "/");


            }
        }
    }
}
