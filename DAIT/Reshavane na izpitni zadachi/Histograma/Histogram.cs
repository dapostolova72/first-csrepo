using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           double bp1 = 0.00;
            double bp2 = 0.00;
            double bp3 = 0.00;
            double bp4 = 0.00;
            double bp5 = 0.00;
            double br = 0.00;
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("Vavedete chislo");
                int chislo = int.Parse(Console.ReadLine());
                 br++;
                if(chislo<200)
                { bp1 += 1; }
                else
                if (chislo >= 200 && chislo<=399)
                { bp2 += 1; }
                else
                if (chislo>=400 && chislo<=599)
                { bp3 += 1; }
                else
                if (chislo>=600 && chislo<=799)
                { bp4 += 1; }
                else
                if (chislo >800)
                { bp5 += 1; }
                                                        
            }
            
            Console.WriteLine("{0:0.00}%", 100 * bp1 /br);
            Console.WriteLine("{0:0.00}%", 100 * bp2 / br);
            Console.WriteLine("{0:0.00}%", 100 * bp3 / br);
            Console.WriteLine("{0:0.00}%", 100 * bp4 / br);
            Console.WriteLine("{0:0.00}%", 100 * bp5 / br);



        }
    }
}
