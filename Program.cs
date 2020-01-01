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
           Console.WriteLine(r/times(h,m,s));
            Console.WriteLine(razskm(r) / timeh(h, m, s));
            Console.WriteLine(mili(r)/timeh(h,m,s));

           

        }
    }
}
