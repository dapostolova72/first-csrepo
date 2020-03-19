using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cenzura2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete dumata za cenzurirane");
            string duma = Console.ReadLine();
            string duma2 = new string('*', duma.Length);

            Console.WriteLine("Vavedete izrechenieto");
            string izrechenie = Console.ReadLine();
            string podmeneno = izrechenie.Replace(duma, duma2);
            Console.WriteLine(podmeneno);


        }
    }
}
