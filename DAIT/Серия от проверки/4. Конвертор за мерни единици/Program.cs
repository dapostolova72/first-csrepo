using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Конвертор_за_мерни_единици
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete chislo");
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine("vavedete ot kakva merna edinica m, mm, cm, mi, in, km, ft, yd");
            var vhodmerna = Console.ReadLine();
            Console.WriteLine("vavedete v kakva merna edinica m, mm, cm, mi, in, km, ft, yd");
            var izhodmerna = Console.ReadLine();
            if (vhodmerna == "m")
            {
                                               
                if (izhodmerna == "mm")
                {
                    Console.WriteLine(n * 1000 + "mm");

                }

                if (izhodmerna == "cm")
                {
                    Console.WriteLine(n * 100 + "cm");

                }
                if (izhodmerna == "mi")
                {
                    Console.WriteLine(n * 0.000621371192 + "mi");

                }





            }
        }
    }
}
