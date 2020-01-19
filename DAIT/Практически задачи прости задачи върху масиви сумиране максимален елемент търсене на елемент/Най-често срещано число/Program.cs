using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Най_често_срещано_число
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete elementite na masiva edno sled drugo razdeleni s interval");
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int savpadenia = 1;
            int kolkopati = 1;//broi kolko pati savpada parvoto chislo koeto nameri 
            int povtariashto = 0;//priemame che tova chislo e syvpadashtoto
                   
                     
             for (int i = 0; i < masiv.Length - 1; i++)
            {
                if (masiv[i] == masiv[i + 1])
                  kolkopati++;
                else kolkopati = 1;

                if (kolkopati > savpadenia)
                {
                    savpadenia = kolkopati;
                    povtariashto = masiv[i];
                }
            }
                         
            Console.Write("{0} ", povtariashto);
        }
    }
}
