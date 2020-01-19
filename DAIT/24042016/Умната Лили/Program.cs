using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Vavedete godinite na Lili");
            int n = int.Parse(Console.ReadLine());
           // Console.WriteLine("Vavedete cenata na peralniata");
            double cena = double.Parse(Console.ReadLine());
          //  Console.WriteLine("Vavedete edinichnata cena na igrachkite");
            double p= double.Parse(Console.ReadLine());
            double spestiavania = 0.00;
          double broiach = 0.00;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                { spestiavania = spestiavania + i*5;
                    spestiavania = spestiavania - 1;
                }   
                else 
                {
                    broiach++;
                }
            }
          //  Console.WriteLine("Spestenite pari sa"+spestiavania);

            double spesteni = (double)spestiavania + (double)(broiach * p);
          //  Console.WriteLine("Pari ot igrachki "+broiach*p);

            double otgore = (double)(spesteni - cena);
            double M = (double)(cena - spesteni);
            if(spesteni>cena)
                { Console.WriteLine("Yes!{0:f2}",(double)Math.Round(otgore,2)); }
            else
            { Console.WriteLine("No!{0:f2}",(double)Math.Round(M,2)); }




        }
    }
}
