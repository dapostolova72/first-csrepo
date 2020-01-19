using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Закръгляне_на_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            string[] items = inputLine.Split(' ');
            
            double[] nums = items.Select(double.Parse).ToArray();
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
                roundedNums[i] = (int)Math.Round(nums[i],MidpointRounding.AwayFromZero);

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine($"{nums[i]} -> {roundedNums[i]}");

        }
    }
}
