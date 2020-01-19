using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Еднакви_думи
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma1 = Console.ReadLine().ToLower();
            string duma2= Console.ReadLine().ToLower();
            if (duma1 == duma2)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }
    }
}
