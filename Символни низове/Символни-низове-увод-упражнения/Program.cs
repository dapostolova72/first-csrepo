using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Символни_низове_увод_упражнения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete osnova i desetichno chislo na edin red");
            int[] masiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int osnova = masiv[0];
            int chislo = masiv[1];
            List<int> ostataci = new List<int>();
            while(chislo>0)
            { int ostatak = chislo % osnova;
               // Console.WriteLine("ostatak"+ostatak);
                ostataci.Add(ostatak);

                chislo = chislo / osnova;
                //Console.WriteLine("chislo"+chislo);

            }
            //ostataci.Reverse();
            // Console.WriteLine(string.Join("", ostataci));
            for (int i = ostataci.Count-1; i >=0; i--)
            {
                Console.Write(ostataci[i]);

            }
        }
    }
}
