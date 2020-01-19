using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Въвеждане_стойностите_на_масива_на_един_ред
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string values = Console.ReadLine();
            
            string[] items = values.Split(' ');
            
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
                arr[i] = int.Parse(items[i]);
            for (int i = 0; i < items.Length; i++)
                Console.WriteLine(arr[i]);
        }

    }
}
