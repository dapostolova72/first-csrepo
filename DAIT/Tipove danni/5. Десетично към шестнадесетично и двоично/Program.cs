using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Десетично_към_шестнадесетично_и_двоично
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete desetichno chislo");
            int chislo = int.Parse(Console.ReadLine());
            string chislohex = Convert.ToString(chislo, 16).ToUpper();
            Console.WriteLine(chislohex);
            string chislobinary= Convert.ToString(chislo, 2);
            Console.WriteLine(chislobinary);
        }
    }
}
