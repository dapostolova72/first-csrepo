using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тройки_latinski_znaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete chislo");
            int n = int.Parse(Console.ReadLine());
            //za proverka
            char d = (char)('a' + n - 1);
            Console.WriteLine(d);
            for(char i='a';i<=(char)('a'+n-1);i++)
                for (char ii = 'a'; ii <= (char)('a' + n - 1); ii++)
                    for (char iii = 'a'; iii <= (char)('a' + n - 1); iii++)
                    { Console.Write("{0}{1}{2}",i,ii,iii);
                        Console.WriteLine();
                    }
        }
    }
}
