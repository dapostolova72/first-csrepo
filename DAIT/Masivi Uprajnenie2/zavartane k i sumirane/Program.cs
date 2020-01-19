using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavartane_k_i_sumirane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = masiv.Length;
            int[] novmasiv = new int[n];
           // Console.WriteLine("masiwat ima "+n+"elementa");
            Console.WriteLine("Vavedete kolko pati da se zavarti maasiva");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {  Array.Reverse(masiv);
                for(int kol=0;kol<n;kol++)
                { novmasiv[kol] = novmasiv[kol] + masiv[kol]; }
                Console.WriteLine(string.Join(" ", masiv));
               
            }
            Console.WriteLine(string.Join(" ", novmasiv));
        }
    }
}
