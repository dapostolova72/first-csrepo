using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stojnosten_tip
{
    class Program
    {
        public static void Main()
            {
                int num = 10;
                Increment(num, 15);
                Console.WriteLine(num);
            }

            private static void Increment(int num, int value)
            {
                num += value;
            }

        }
    }
