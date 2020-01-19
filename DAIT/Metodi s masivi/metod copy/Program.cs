using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 1, 2, 3, 4, 10, 12, 14, 16 };
            int[] destination = new int[] { 5, 6, 7, 8, 9, 11, 13, 15, 17 };
            Console.WriteLine(string.Join(" ",source));
            Console.WriteLine(string.Join(" ", destination));
            Array.Copy(destination, 0, source, 4, 4);
            Console.WriteLine(string.Join(" ", source));
        }
    }
}
