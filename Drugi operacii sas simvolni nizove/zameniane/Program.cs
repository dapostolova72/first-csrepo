using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zameniane
{
    class Program
    {
        static void Main(string[] args)
        { string cocktail = "Vodka + Martini + Cherry";

        string replaced = cocktail.Replace("+", "and");
            Console.WriteLine(replaced);
            // Vodka and Martini and 
            string nov = replaced.Remove(2, 5);
            Console.WriteLine(nov);
            Console.WriteLine("Vavedete tekst");
            string[] banWords = Console.ReadLine().Split(' '); // TODO: add separators
            Console.WriteLine("Vavedete dumi za zamiana");
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,new string('*', banWord.Length));
                    Console.Write(text);
                }  
            }
         


        }
    }
}
