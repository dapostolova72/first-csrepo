using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Време__15
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double minplus15 = min + 15;

            if (minplus15 > 59)
            {

                minplus15 -= 60;
                hour += 1;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine("{0}:{1:00}", hour, minplus15);

        }
    }
}
