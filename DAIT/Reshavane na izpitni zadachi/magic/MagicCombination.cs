using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if(n>600000)
            { Console.WriteLine("Vavedete po-malko chislo"); }
           
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int e = 0; e <= 9; e++)
                        {
                            for (int m = 0; m <= 9; m++)

                                for (int b = 0; b <= 9; b++)

                            {
                                if (i*k*d*e*m*b==n)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", i, k, d, e, m,b);
                                }
                                    
                            }
                        }
                    }
                }
            }
        }
    }
}
