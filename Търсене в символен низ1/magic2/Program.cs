using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic2
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();
                char [] masiv = duma.Distinct().ToArray();
            Console.WriteLine(string.Join(" ",masiv));
            string duma2 = Console.ReadLine();
            char[] masiv2 = duma2.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", masiv2));
            bool da = true;

            if (masiv.Length == masiv2.Length)
            {

                da = true;


            }
            else
            {
                da = false;

            }
            Console.WriteLine(da);

        }
    }
}
