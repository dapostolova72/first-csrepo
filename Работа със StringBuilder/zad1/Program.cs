using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Console.WriteLine("Vavedete tekst");
            string duma = Console.ReadLine();
            text.Append(duma);
           
            Console.WriteLine("Vavedete komanda");
            string kom = Console.ReadLine();
            List<string> masiv = kom.Split().ToList();
            string komanda = masiv[0];
            string komanda1 = masiv[1];
            string komanda2 = masiv[2];

            switch(komanda)
            { case "Append":


                    text.Append(komanda1);
                    Console.WriteLine(text);
                    break;

                case "Remove":

                    int pos = int.Parse(komanda1);
                    int broi = int.Parse(komanda2);
                   
                    text.Remove(pos,broi);
                     Console.WriteLine(text);

                    break;

                case "Insert":
                    int pos1 = int.Parse(komanda1);
                    text.Insert(pos1,komanda2);
                    Console.WriteLine(text);

                    break;



            }
         
        }
    }
}
