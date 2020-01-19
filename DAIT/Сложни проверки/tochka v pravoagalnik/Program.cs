using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochka_v_pravoagalnik
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Vavedete koordinati na tochkata D");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete koordinati na tochkata B");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete koordinati na tochkata M");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if(x>=x1&&x<=x2 &&y<=y1&&y>=y2)
            { Console.WriteLine("Tochkata e vatre"); }
            else {
                Console.WriteLine("Tochkata e izvan");
            }
        }

     

                }






            

}



