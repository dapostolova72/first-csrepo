using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skorost_s_metod
{
    class Program
    { //vremeto v sekundi//
        static float times(float h, float m, float s)
        { 
            float time = h * 3600 + m * 60 + s;
            return time;
        }
        //vremeto v chas//
        static float timeh(float h, float m, float s)
        {   
            float timechas = h + m / 60 + s / 3600;
            return timechas;
        }
        //metrite v mili//
        static float mili(float r)
        { 
            float metrivmili = r / 1609;
            return metrivmili ;
        }
        //razstoianieto v km//
        static float razskm(float r)
        {
            float rkm = r / 1000;
            return rkm;
        }

        static void Main(string[] args)
        {Console.WriteLine("Vavedete razstoianieto v metri");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete chasovete");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete minuti");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Vavedete secundi");
            float s = float.Parse(Console.ReadLine());
            Console.WriteLine(r/times(h,m,s));
            Console.WriteLine(razskm(r) / timeh(h, m, s));
            Console.WriteLine(mili(r)/timeh(h,m,s));




        }
    }
}
