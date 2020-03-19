using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Намиране_на_подниз_в_даден_символен_низ
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "vasko@gmail.org";
            Console.WriteLine(email);
            int firstIndex = email.IndexOf("@"); // 5
            int point = email.IndexOf(".");

            Console.WriteLine(point);
            int secondIndex = email.LastIndexOf("o"); 
            Console.WriteLine(secondIndex);
            int notFound = email.IndexOf("/"); // -1
            Console.WriteLine(notFound);

        }
    }
}
