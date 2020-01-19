using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Преливане_на_вода
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko naliwaniq iskate");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
               
                int l = int.Parse(Console.ReadLine());
                suma = suma + l;
                if (suma <= 255)
                {
                  
                }
                else
                if (suma > 255)
                {

                    suma = suma - l;
                    Console.WriteLine("Insufficient capacity!\n");
                   
                }
                
            }
Console.WriteLine("V sada ima " + suma + "voda");
        }

    }
}

