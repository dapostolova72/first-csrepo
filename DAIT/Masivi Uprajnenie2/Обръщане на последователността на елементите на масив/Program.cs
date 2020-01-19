using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обръщане_на_последователността_на_елементите_на_масив
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete broia na elementita na masiva");
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            for(int i=0;i<n;i++)
            { Console.WriteLine("vavedete elementit na masiva");
                masiv[i] = int.Parse(Console.ReadLine());
            }
            for(int i=n-1;i>=0;i--)
            { Console.Write(masiv[i]+" " ); }
        }
    }
}
