using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Проверка_на_число
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete chislo");
            double chislo = double.Parse(Console.ReadLine());

            if (chislo %2==0 || chislo%2==1  )
          
                  { Console.WriteLine("integer");
                Console.WriteLine(chislo % 2);
                Console.WriteLine(chislo % 1);
            }
            else
            { Console.WriteLine("floating-point");
                Console.WriteLine(chislo%2);
                Console.WriteLine(chislo%1);
            }
        } }
    

}