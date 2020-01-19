using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Знаци_и_кодове
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'd';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'b';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'A';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'щ';  // кирилската буква „щ“
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            string  a= "\u0065";
            Console.WriteLine(a);

        }
    }
}
