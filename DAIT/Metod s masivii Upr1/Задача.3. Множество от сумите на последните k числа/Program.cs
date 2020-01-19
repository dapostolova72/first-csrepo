using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._3.Множество_от_сумите_на_последните_k_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete broia na chislata");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            masiv[0] = 1;
            Console.WriteLine("Vavdete do koe chislo");
            int k = int.Parse(Console.ReadLine());
            int s = 0;
          
            for(int i=1;i<=k;i++)
            { masiv[i] = s + masiv[i-1];
                s = s + masiv[i - 1];
            }
          
            for (int i=k+1;i<n;i++)
            {
               for(int d=i-k;d<i-1;d++)
                  
                s = s + masiv[d];
                masiv[i] = s + masiv[i];
             
            }
            Console.WriteLine(string.Join(" ",masiv));
        }
    }
}
