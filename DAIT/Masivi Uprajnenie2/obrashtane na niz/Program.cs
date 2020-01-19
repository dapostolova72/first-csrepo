using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrashtane_na_niz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] masiv = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(masiv);
            Console.WriteLine(string.Join(" ", masiv));
        }
    }
}
