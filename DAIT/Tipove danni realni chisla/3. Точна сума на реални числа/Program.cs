using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Точна_сума_на_реални_числа
{
    class Program
    {
        static void Main(string[] args)
      {
            int n = int.Parse(Console.ReadLine());
            decimal s = 0M;
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Vavedete chislo");
                decimal chislo = decimal.Parse(Console.ReadLine());
                s = s + chislo;

            }
            Console.WriteLine(s);
        }
    }
}
