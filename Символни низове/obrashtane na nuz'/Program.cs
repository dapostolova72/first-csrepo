using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrashtane_na_nuz_
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();
            List<string> dumi = new List<string>();
            for (int i=0;i<duma.Length;i++)
            {
                Console.Write(duma[i]);
                dumi.Add(duma[i].ToString());

               
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", dumi));
        }
    }
}
