﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chetni_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int  n = 0;
            while (n>=0)
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                        break;
                    Console.WriteLine("The number is not even.");
                }

                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            Console.WriteLine("The number is even.");
        }
    }
}
       
    
