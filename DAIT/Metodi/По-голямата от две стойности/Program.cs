using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace По_голямата_от_две_стойности
{
    class Program
    {static void GetMax()
        { Console.WriteLine("Vavedete tipa na promenlivata  int, char ili string");
            string tip = Console.ReadLine();
            if (tip == "int")
            {
                Console.WriteLine("Vavedete chislo");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Vavedete chislo");
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                { Console.WriteLine(a); }
                else
                {
                    Console.WriteLine(b);
                }
            }

            if (tip == "char")
            {
                Console.WriteLine("Vavedete znak");
                char a = char.Parse(Console.ReadLine());
                Console.WriteLine("Vavedete znak");
                char b = char.Parse(Console.ReadLine());
                if (a > b)
                { Console.WriteLine(a); }
                else
                {
                    Console.WriteLine(b);
                }
            }
            if (tip == "string")
            {
                Console.WriteLine("Vavedete duma");
                string a = Console.ReadLine();


                Console.WriteLine("Vavedete duma");
                string b = (Console.ReadLine());

                if (a[0] < b[0])
                { Console.WriteLine(a); }
                else
                {
                    Console.WriteLine(b);
                }
            }

        }



        static void Main(string[] args)
        {
            GetMax();
        }
    }
}
