using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_на_големи_числа
{
    class Program
    {
        
        
            // Сума на две числа
            static String Sum(String num1, String num2)
            {
                String rezult = String.Empty;

                // Уеднаквяване чрез добавяне на нули
                if (num1.Length < num2.Length)
                num1 = new String('0', num2.Length - num1.Length) + num1;
                else num2 = new String('0', num1.Length - num2.Length) + num2;

            // Индекси
           
            int k = 0;
           

                // Обхождаме низовете отзад напред и намираме сумата
                for (int i = num1.Length - 1; i >= 0; i--)
                {
                    int s= (int)num1[i] + (int)num2[i] - 96; // ASCII

               
                    if (k > 0)
                    {
                        s = s + k;
                     
                    }
                
                    if (s > 9)
                    {
                        k = s/ 10;
                        s = s % 10; 

                    }
                    rezult=rezult + s.ToString();
                           
                   }
  
                     rezult = rezult + k.ToString();
                // Връщаме резултата
                return string.Join("", rezult.Reverse());
            }


            static void Main(string[] args)
            {
           
            Console.WriteLine("Vavedete chislo");
                String A = Console.ReadLine();
            Console.WriteLine("Vavedete chislo");
            String B = Console.ReadLine();

                Console.Write(Sum(A, B));


            }
        }
    }

    