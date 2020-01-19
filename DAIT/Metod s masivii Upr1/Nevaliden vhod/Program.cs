using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevaliden_vhod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete posledovatelno  masiv ot stringove");

            string[] masiv = Console.ReadLine().Split();
            string[] command = new string[10];

            do
            {
                Console.WriteLine(" Vavedete komandi");
                 command = Console.ReadLine().Split();



                try
                {
                    switch (command[0].ToLower())
                    {
                        case "reverse":

                            Array.Reverse(masiv);

                            break;



                        case "distinct":
                            masiv = masiv.Distinct().ToArray();
                            break;
                        case "replace":

                            int index = int.Parse(command[1]);
                            string newWord = command[2];
                            masiv[index] = newWord;

                            break;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Invalid input");

                }
            }
            while (command[0].ToLower() != "end") ;
            Console.WriteLine(string.Join(",", masiv));
            
            



           

        }
    }
}
       
