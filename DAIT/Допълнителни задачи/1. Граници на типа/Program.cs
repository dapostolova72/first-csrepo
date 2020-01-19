using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Граници_на_типа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete type int, “uint”, “long”, “byte” и “sbyte");
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    Console.WriteLine(Int32.MinValue);
                    Console.WriteLine(Int32.MaxValue);
                    break;
                case "uint":
                    Console.WriteLine(UInt32.MinValue);
                    Console.WriteLine(UInt32.MaxValue);
                    break;
                case "long":
                    Console.WriteLine(Int64.MinValue);
                    Console.WriteLine(Int64.MaxValue);
                    break;
                case "byte":
                    Console.WriteLine(byte.MinValue);
                    Console.WriteLine(byte.MaxValue);
                    break;
                case "sbyte":
                    Console.WriteLine(sbyte.MinValue);
                    Console.WriteLine(sbyte.MaxValue);
                    break;
            }

        }
    }
}
