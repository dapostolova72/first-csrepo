using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Знакови_литерали
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = 'a'; // Обикновен знак
            char symbol2 = '\u006F'; // Уникод знак
                               // в 16-ичен формат (буква 'o')
            
            char symbol3 = '\u8449'; // 葉 (Листо в Традиционен китайски)
           char  symbol4 = '\''; // Присвояване на апостроф
           char symbol5 = '\\'; // Присвояване на наклонена
            char symbol6 = '\n'; // Присвояване на знак за нов ред
           char symbol7 = '\t'; // Присвояване на знак TAB
                                //symbol = "a";  // Неправилно: използвайте апострофи!
            Console.WriteLine(symbol1+"\n"+symbol2+"\n" + symbol3+"\n" + symbol4+"\n" + symbol5+"\n" + symbol6);

        }
    }
}
