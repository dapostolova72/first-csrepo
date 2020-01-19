using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = new int[] { 1, 2, 3 ,4,5};
            
            int[] destination = new int[] { 6,7,8,9,10,11,12};
            source.CopyTo(destination, 0);
            Console.WriteLine(string.Join(" ", destination));
        }
    }
}
