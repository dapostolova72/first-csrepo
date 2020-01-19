using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice_na_kvadrat_Metod_s_parametar
{
    class Program
    {
        static double Licekvadrat(double a)
        { return a * a; }


        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete  stranata na kvadrat");
            double b = double.Parse(Console.ReadLine());
            var s=Licekvadrat(b);
            Console.WriteLine(s);
        }
    }
}
