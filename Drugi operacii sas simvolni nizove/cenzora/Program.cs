using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cenzura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete duma za cenzorirane");

            String Word = Console.ReadLine();

            // Заместващата дума
            String Replacement = new String('*', Word.Length);

            Console.WriteLine("vavedete teksta koito shte se cenzurira");
            String Sentance = Console.ReadLine();

            // Цензурираме
            String Replaced = Sentance.Replace(Word, Replacement);

         
            Console.WriteLine(Replaced);
        }
    }
}
