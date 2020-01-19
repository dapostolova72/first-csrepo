using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dopalnitelna
{
    class Program
    {     static void Suma()
        {
            double suma = 0;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("vavedete chislo");
                double chislo = double.Parse(Console.ReadLine());
                suma = suma + chislo;

            }

            Console.WriteLine("Sumata e:" + suma);
        }


        static void Main(string[] args)
        {
            Suma();
        }
    }
}
