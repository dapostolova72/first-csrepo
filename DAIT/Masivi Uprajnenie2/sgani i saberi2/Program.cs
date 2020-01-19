using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgani_i_saberi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
          
            int n = masiv.Length;
            int k = n / 2;
            int r = n/ 4;
            int[] masiv1 = new int[r];
            for(int i=0;i<r;i++)
            {
                masiv1[i] = masiv[i];
                Array.Reverse(masiv1);
                Console.WriteLine(string.Join(" ",masiv1));
            }
            int[] masivsreda = new int[k+1];
            for (int i = r; i <k+1; i++)
            {
                masivsreda[i] = masiv[i];

               
            }

            Console.WriteLine("nnbnbnb"+masivsreda[r]);
                Console.WriteLine("nnbnbnb" + masivsreda[k]);

            Console.WriteLine(string.Join(" ", masivsreda));

        }
    }
}
