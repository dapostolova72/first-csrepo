using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._5.Умножаване_на_символни_кодове
{
    class Program



    {static int Umnojeninizove(string str1, string str2)
        {
           
            int proizvedenie = 1;
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    proizvedenie = str1[i] * str2[i];
                }
            }
            else if (str1.Length >= str2.Length)
            {

                for (int i = 0; i < str2.Length; i++)
                {
                    proizvedenie = str1[i] * str2[i];
                }
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    proizvedenie = proizvedenie + str1[i];
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    proizvedenie = str1[i] * str2[i];
                }
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    proizvedenie = proizvedenie + str2[i];
                }
            }
           return proizvedenie;
        }




        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(Umnojeninizove(str1,str2));

            }
        }
     }

    





