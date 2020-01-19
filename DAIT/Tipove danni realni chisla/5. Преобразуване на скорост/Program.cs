using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Преобразуване_на_скорост
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete razstoianieto v metri");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete chasovete");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete minuti");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete secundi");
            float s = float.Parse(Console.ReadLine());
            //vremeto v sekundi/
            float time = h * 3600 + m * 60 + s;
            Console.WriteLine(r/time);
            //vremeto v chas//
            float timechas = h + m / 60 + s / 3600;
            //razstoianieto v km//
            float rkm = r / 1000;
            Console.WriteLine(rkm/timechas);
            //metrite v mili/
            float mili = r / 1609;
            Console.WriteLine(mili/timechas);
            

           

        }
    }
}
