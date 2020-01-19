using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpolzvane_na_niakolko_parametara
{
    class Program
    {
        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
        }



        static void Main(string[] args)
        {
            PrintNumbers(5, 10);

        }
    }
}
