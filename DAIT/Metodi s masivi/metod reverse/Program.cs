using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_reverse
{
    class Program
    {
        static void Main(string[] args)
        { int [] arr=new int []{ 1,2,3,4,5};
           Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }
           
            
        }
    }
}
