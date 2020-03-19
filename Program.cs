using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._2.Преобразуване_от_N_ична_в_10_ична_ПБС
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete osnova i  chislo na edin red");
           int [] masiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<double> dec = new List<double>();
           
            int osnova = masiv[0];
            int  chislo = masiv[1];
            int br = 0;
        double  proizvedenie = 1;          
            while(chislo>0)
            {
                             
              double edinici = chislo % 10;
                proizvedenie = Math.Pow(osnova, br);                      
                 dec.Add(edinici*proizvedenie);             
                 chislo = chislo / 10;
                br++;               
            }
            int s = 0;
            for (int i = 0; i < dec.Count; i++)
            {
                s = s + (int)dec[i];
            }
           
            Console.WriteLine("Desetichnoto chislo e"+s);
                

           
            

        }
    }
}
