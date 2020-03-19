using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skrivalishte
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            bool found = false;
            do
            {
                string[] positioning = Console.ReadLine().Split(' ').ToArray();
                string sign = positioning[0];
                int needed = int.Parse(positioning[1]);

                if (card.Contains(sign))
                {
                    int counter = 0;
                    int index = card.IndexOf(sign);
                    while (index != -1)
                    {
                        counter++;
                        index = card.IndexOf(sign, index + 1);
                    }
                    if (counter >= needed)
                    {
                        Console.WriteLine("Hideout found at index {0} and it is with size {1}!", card.IndexOf(sign), counter);
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
            }
            while (found == false);
        }
    }
}

   