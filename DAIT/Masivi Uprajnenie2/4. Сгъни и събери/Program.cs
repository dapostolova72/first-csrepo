using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Сгъни_и_събери
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            Array.Reverse(numbers);

            int[] result = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                result[i] =result[i]+ numbers[numbers.Length - k + i] + numbers[numbers.Length - k - i - 1];
                result[i + k] = result[i + k]+ numbers[i] + numbers[numbers.Length - (2 * k) - i - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
            
