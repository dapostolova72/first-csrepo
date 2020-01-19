using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Туристическа_информация
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete imperska edinica");
            string imperska = Console.ReadLine();
            Console.WriteLine("Vavedete stoinostta");
            double stoinost = double.Parse(Console.ReadLine());
            switch (imperska)
            {
                case "miles":
                    double km = 1.6 * stoinost;
                    Console.WriteLine("{0} miles={1:f2} km", stoinost, km);
                    break;

                case "inch":
                    double cm = 2.54 * stoinost;
                    Console.WriteLine("{0} inch={1:f2} cm", stoinost, cm);
                    break;

                case "feet":
                    double cm1 = 30* stoinost;
                    Console.WriteLine("{0} feet={1:f2} cm", stoinost, cm1);
                    break;
                case "yard":
                    double m = 0.91 * stoinost;
                    Console.WriteLine("{0} yard={1:f2} m", stoinost, m);
                    break;
                case "galoni":
                    double litra = 3.8 * stoinost;
                    Console.WriteLine("{0} galoni={1:f2} litra", stoinost, litra);
                    break;




            }

            }
        }
    }

