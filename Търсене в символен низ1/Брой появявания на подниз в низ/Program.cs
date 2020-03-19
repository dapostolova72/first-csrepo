using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Брой_появявания_на_подниз_в_низ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete izrechenie");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("vavedete duma  za tyrsene");
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(pattern);
            Console.WriteLine("Parvia pat kogato sre[ne niza"+index);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
                Console.WriteLine("Poziciqta na koiato se premestva"+index);
            }
            Console.WriteLine(counter);

        }
    }
}
