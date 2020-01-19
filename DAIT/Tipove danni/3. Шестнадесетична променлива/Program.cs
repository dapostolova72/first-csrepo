using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Шестнадесетична_променлива
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete shestnadesetichno chislo vav format 0x##" );
            string chislo = Console.ReadLine();
            int chislodec = Convert.ToInt32(chislo, 16);
            Console.WriteLine("Chisloto e:"+chislodec);
          
          

        }
    }
}
