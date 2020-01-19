using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._1.Сравняване_на_символни_масиви
{
    class Program
    {
        static void Main(string[] args)
        { string[] masiv1 = Console.ReadLine().Split().ToArray();
            int n = masiv1.Length;
            string[] masiv2 = Console.ReadLine().Split().ToArray();
            int d = masiv2.Length;
            if (n == d)
            {
                for (int i = 0; i < n; i++)

                    if (masiv1[i] == masiv2[i])
                    {
                       Array.Sort(masiv1);
                        Array.Sort(masiv2);

                    }
                Console.WriteLine(string.Join("", masiv1));
                Console.WriteLine(string.Join("", masiv2));
            }
            else
            {
                Console.WriteLine("Ne sa ednakwi");
            }
                        }

        }
    }

