using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            List<string> dumi = new List<string>();
            
            string str2 = Console.ReadLine();

            int result = string.Compare(str1, str2, true);
            Console.WriteLine(result);

        }
    }
}
