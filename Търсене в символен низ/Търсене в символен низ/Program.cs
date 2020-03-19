using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Търсене_в_символен_низ
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "UP Programirane RPP";
            int indexp = text.IndexOf("P");
            Console.WriteLine(indexp);
            int indexp2 = text.IndexOf("P", 2);
            Console.WriteLine(indexp2);
            int lastindex= text.LastIndexOf("P");
            Console.WriteLine(lastindex);
        }
    }
}
