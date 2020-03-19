using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сбор_на_големи_числа
{
    class Program
    {


        static String Multiply(String num1, int num2)
        {
            String Result = String.Empty;
         
                int dobavka = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int current = num2 * ((int)num1[i] - 48); // ASCII
               
                if (dobavka > 0)
                {
                    current +=dobavka;
                    dobavka = 0;
                }
                if (current > 9)
                {
                    dobavka = current / 10;
                    current = current % 10;
                }
                Result += current.ToString();
             
            }

           
            if (dobavka > 0)
                Result += string.Join("", dobavka.ToString().Reverse());

            return string.Join("", Result.Reverse());
        }

        static void Main(string[] args)
        {
            String BigNumber = Console.ReadLine();
            int Multiplyer = int.Parse(Console.ReadLine());
            Console.Write(Multiply(BigNumber, Multiplyer));
        }
    }
}




