using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetniNechetn
{
    class EvenOddMultiplication
    {


        static int GetSumOfEvenDigits(int chislo)
        {


            int suma = 0;

            while (chislo != 0)
            {
                int chislo1 = chislo % 10;
                chislo = chislo / 10;
                if (chislo1 % 2 == 0)
                {
                    suma = suma + chislo1;
                }
            }
            return suma;

        }


        static int GetSumOfOddDigits(int chislo)
        {
            int suma5 = 0;

            while (chislo != 0)
            {
                int chislo1 = chislo % 10;
                chislo = chislo / 10;
                if (chislo1 % 2 == 1)
                {
                    suma5 = suma5 + chislo1;
                }
            }
            return suma5;

        }

        static int GetMultipleOfEvensAndOdds(int a, int b)
        {
            return a * b;


        }

        static void Main(string[] args)
        {
           // Console.WriteLine("Vavedete chislo");
            int chislo2 = int.Parse(Console.ReadLine());
            if (chislo2 < 0)
            { chislo2 = Math.Abs(chislo2); }
            int s = GetSumOfEvenDigits(chislo2);
           // Console.WriteLine("Четна сума" + s);
            int sn = GetSumOfOddDigits(chislo2);
           // Console.WriteLine("Нечетна сума" + sn);
            Console.WriteLine(GetMultipleOfEvensAndOdds(s, sn));


        }
    }
}
