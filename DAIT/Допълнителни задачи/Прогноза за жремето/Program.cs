using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогноза_за_жремето
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            try
            { Console.WriteLine("Vavedete chislo");
            long chislo = long.Parse(Console.ReadLine());
                if (chislo >= sbyte.MinValue && chislo <= sbyte.MaxValue)
                { Console.WriteLine("Sunny"); }
                else if (chislo >= int.MinValue && chislo <= int.MaxValue)
                { Console.WriteLine("Cloudy"); }
                else if (chislo >= long.MinValue && chislo <= long.MaxValue)
                { Console.WriteLine("Windy"); }
            }
            catch { 
            
                 Console.WriteLine("Rainy"); }
            }


        }
    }

