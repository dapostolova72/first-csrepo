using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Връща_стойност_string
{
    class Program
    {
        static string ReadFullName()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReadFullName());
            

        }
    }
}
