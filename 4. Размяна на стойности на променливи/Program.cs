using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Размяна_на_стойности_на_променливи
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vadedete a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vadedete b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);


        }
    }
}
