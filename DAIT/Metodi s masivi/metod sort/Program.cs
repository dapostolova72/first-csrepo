using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 2, 3, 14, 5 };
            Array.Sort(arr);
           
            Console.WriteLine(string.Join(" ", arr));
            Array.Reverse(arr);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }

        }
    }
}
