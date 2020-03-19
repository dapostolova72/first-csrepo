using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace samo_bukvi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d+)([A-Za-z])";
           // Console.WriteLine(pattern);
            string text = Console.ReadLine();
            foreach (Match match in Regex.Matches(text, pattern))
            {
                text = Regex.Replace(text, match.Groups[1].Value, match.Groups[2].Value);
            }
            Console.WriteLine(text);
        }
    }
}