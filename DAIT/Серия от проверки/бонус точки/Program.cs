using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace бонус_точки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete broi tochki");
            int tochki = int.Parse(Console.ReadLine());

            if (tochki <= 100)
            {
                double bt = 5;
                // Console.WriteLine("Bonus tochkite bez dopalnitelnite" + bt);
                double dbt = 0;
                if (tochki % 2 == 0)
                {
                    dbt = 5 + 1;
                    Console.WriteLine("Bonusi wsichko:" + dbt);
                    double obshto = tochki + 6;
                    Console.WriteLine("Obshto tochni" + obshto);
                }
                else
                if (tochki % 10 == 5)
                {
                    dbt = 5 + 2;
                    double obshto = tochki + 7;
                    Console.WriteLine("Bonusi wsi`ko:" + dbt);
                    Console.WriteLine("Obshto tochni" + obshto);
                }

                else
                {
                    double td = tochki + bt;
                    Console.WriteLine("Wsicki tochki sa" + td);
                }
            }



            if (tochki > 100 && tochki <= 1000)
            {
                double bt = 0.20 * tochki;
                // Console.WriteLine("Bonus tochkite bez dopalnitelnite" + bt);
                double dbt = 0;
                if (tochki % 2 == 0)
                {
                    dbt = 0.20 * tochki + 1;
                    Console.WriteLine("Bonusi wsi`ko:" + dbt);
                    double obshto = (0.20 * tochki) + tochki + 1;
                    Console.WriteLine("Obshto tochni" + obshto);
                }
                else
                if (tochki % 10 == 5)
                {
                    dbt = 0.20 * tochki + 2;
                    double obshto = tochki + 0.20 * tochki + 2;
                    Console.WriteLine("Bonusi wsi`ko:" + dbt);
                    Console.WriteLine("Obshto tochni" + obshto);
                }

                else
                {
                    double td = tochki + bt;
                    Console.WriteLine("Wsicki tochki sa" + td);
                }
            }
            if (tochki > 1000)
            {
                double bt = 0.10 * tochki;
                // Console.WriteLine("Bonus tochkite bez dopalnitelnite" + bt);
                double dbt = 0;
                if (tochki % 2 == 0)
                {
                    dbt = 0.10 * tochki + 1;
                    Console.WriteLine("Bonusi wsi`ko:" + dbt);
                    double obshto = (0.10 * tochki) + tochki + 1;
                    Console.WriteLine("Obshto tochni" + obshto);
                }
                else
                if (tochki % 10 == 5)
                {
                    dbt = 0.10 * tochki + 2;
                    double obshto = tochki + 0.10 * tochki + 2;
                    Console.WriteLine("Bonusi wsi`ko:" + dbt);
                    Console.WriteLine("Obshto tochni" + obshto);
                }

                else
                {
                    double td = tochki + bt;
                    Console.WriteLine("Wsicki tochki sa" + td);
                }
            }

        }




    }
}




