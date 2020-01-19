using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Завъртане_и_сумиране
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete broia na elementite na masiva");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete kolko pati da se obarne masiva");
            int k = int.Parse(Console.ReadLine());

            int[] masiv = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vavedete element");
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", masiv));
            Console.WriteLine("Sled reverse");
            for (int b = 0; b < k; b++)
            {
                Array.Reverse(masiv);
                Console.WriteLine(string.Join(" ", masiv));
            }
            int[] sum = new int[k * n];
            for (int r = 1; r < k; r++)
            {
                for (int i = 0; i <= n - 1; i++)
                    sum[r] = masiv[i];
                Console.WriteLine("Sumata e" + sum[r]);
                
            }
        }
    }
}
