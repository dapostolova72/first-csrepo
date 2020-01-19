using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Извеждане_на_масив_на_конзолата
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three", "four", "five" };
            // Process all array elements
            for (int index = 0; index < arr.Length; index++)
            {
                // Print each element on a separate line
                Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
            }

        }
    }
}
