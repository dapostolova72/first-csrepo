using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._1.Магически_променящи_се_думи
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string [] masiv = new string [65599];
           
            for (int i = 0; i < str1.Length; i++)
            { if (str1[i] == str1[i + 1])
                {
                    masiv[i] = masiv[i]+1;

                }

            }

            Console.WriteLine(string.Join(" ",masiv));
        }
    }
}
