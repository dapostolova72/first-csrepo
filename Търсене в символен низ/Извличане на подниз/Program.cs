﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Извличане_на_подниз
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Pics\Rila2017.jpg";
            string nameAndExtension = filename.Substring(8,8);
            Console.WriteLine(nameAndExtension);

        }
    }
}
