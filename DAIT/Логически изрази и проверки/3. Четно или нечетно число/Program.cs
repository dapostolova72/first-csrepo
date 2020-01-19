using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Четно_или_нечетно_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
             Console.WriteLine("Even"); 
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
