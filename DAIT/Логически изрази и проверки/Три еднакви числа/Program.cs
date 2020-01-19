using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Три_еднакви_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());
            int chislo3 = int.Parse(Console.ReadLine());
            if (chislo1 == chislo2 && chislo2 == chislo3)
            { Console.WriteLine("Yes");
        }
            else
            { Console.WriteLine("No"); }
        }
    }
}
