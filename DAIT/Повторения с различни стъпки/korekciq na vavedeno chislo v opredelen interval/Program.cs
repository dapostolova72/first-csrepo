using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korekciq_na_vavedeno_chislo_v_opredelen_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Vavdete chislo w intervala 1 do 100");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", num);

        }
    }
}
