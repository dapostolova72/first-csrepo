using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статистика_на_масив
{
    class Program
    {
        static void Main(string[] args)
        {
            string razdelitel = Console.ReadLine();
            string []star = razdelitel.Split(' ');
            int [] masiv = star.Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ",masiv));
           // най - малкия елемент, най - големия елемент, сумата на елементите и средната им стойност.
                int min= masiv[0];
            int max = masiv[0];
            int s = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] < min)
                {
                    min = masiv[i];
                }
                if (masiv[i] > max)
                {
                    max = masiv[i];
                }

                s = s + masiv[i];

            }
            Console.WriteLine("Min=" + min);
            Console.WriteLine("Max=" + max);
            Console.WriteLine("Sum="+s);
            Console.WriteLine("Srednata stojnost ="+(double)s/masiv.Length);




            }
        }
}
