using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicod
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();
            for (int i = 0; i < duma.Length; i++)
            {
                Console.WriteLine("\\u" + ((int)duma[i]).ToString("X4"));
              

            }
            Console.WriteLine();

            char d = 'f';
            Console.WriteLine("\\u" + ((int)d).ToString("X4"));
            string n= Convert.ToString((int)d, 16);
            int l = n.Length;


            Console.WriteLine("\\u{0}{1:f4}",new string('0',4-l),Convert.ToString((int)d,16));


        }  
    }
}
