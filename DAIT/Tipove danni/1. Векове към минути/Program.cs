using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Векове_към_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete centuries");
            byte centuries = byte.Parse(Console.ReadLine());
     ushort years = (ushort)(centuries * 100);
            int days = (int) (years * 365.2422);
            int hours = years * 365 * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} centuries= {1}years={2}days={3}hours={4} minuts", centuries, years, days, hours, minutes);

            

        }
    }
}
