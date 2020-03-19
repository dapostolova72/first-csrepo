using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_na_g_c2222
{
    class Program
    {
      
       
            // Сума на две числа
            static String Sum(String A, String B)
            {
                String C = String.Empty;

                // Уеднаквяване чрез добавяне на нули
                if (A.Length < B.Length) A = new String('0', B.Length - A.Length) + A;
                else B = new String('0', A.Length - B.Length) + B;

                // Индекси
                int j = 0, PART = 0;

                // Обхождаме низовете отзад напред и намираме сумата
                for (int i = A.Length - 1; i >= 0; i--)
                {
                int SUM = (int)A[i] + (int)B[i] - 96; // ASCII
                if (PART > 0)
                {
                    SUM = SUM + PART;
                    PART = 0;
                }
                if (SUM > 9)
                {
                    PART = SUM / 10;
                    SUM = SUM % 10;
                }
                C += SUM.ToString();
                j++;
            }

            // Връщаме резултата
            return string.Join("", C.Reverse());
            }

            static void Main(string[] args)
            {
                // Входни данни
                String A = Console.ReadLine();
                String B = Console.ReadLine();

                // Отпечатваме резултата
                Console.Write(Sum(A, B));
            }
        }
    }

    