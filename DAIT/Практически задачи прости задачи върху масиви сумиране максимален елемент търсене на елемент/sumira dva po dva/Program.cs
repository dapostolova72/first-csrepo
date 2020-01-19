using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumira_dva_po_dva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];

            // Компресиран масив
            int n = nums.Length;
            while (n != 1)

            
            {
                for (int i = 0; i < n - 1; i++)
                            condensed[i] = nums[i] + nums[i + 1];
                           
                nums = condensed;

                n--;
                
            } 

            // Резултат
            Console.WriteLine(condensed[n - 1]);

        }
    }
}

        
    

