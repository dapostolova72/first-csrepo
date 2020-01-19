using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace povtariashti_chisla_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete elementite na masiva edno sled drugo razdeleni s interval");
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 0;
            int povtaria = masiv[0];
            int i = -1;
            int j;
            do
            {
                i++;
                j = i + 1;

                while (masiv[i] == masiv[j] && j < masiv.Length - 1) j++;
            } while (masiv[i] == masiv[j] && i < masiv.Length - 2);
            if (masiv[i] == masiv[j])
                br++;
            povtaria = masiv[i];
            Console.WriteLine("Chisloto se povtaria" + br + " pati ");
            Console.WriteLine("Chisloto koeto se povtaria e" + povtaria);


        }
    }
}
