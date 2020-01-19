using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индекс_на_буква
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete masiv ot anglijski bukvi");
            char[] masiv = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Console.WriteLine("vavedete duma");
            string duma = Console.ReadLine();
                        
            for (int i = 0; i < masiv.Length; i++)
                for(int j=0;j<duma.Length;j++)
            if(masiv[i]==duma[j])
                    Console.WriteLine("{0} -> {1}", duma[j], i);

            }
        }
    } 