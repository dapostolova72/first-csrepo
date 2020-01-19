using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумиране_на_секунди
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());

            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int obshto = sec1 + sec2 + sec3;
            if (obshto <= 59)
            { Console.WriteLine("0:{0:00}", obshto); }
            else
                if (obshto <= 119)
            {
                int obshto1 = obshto - 60;
                Console.WriteLine("1:{0:00}", obshto1);
            }

            else
                if (obshto <= 179)
            {
                int obshto1 = obshto - 120;
                Console.WriteLine("2:{0:00}", obshto1);
            }

        }

    }
}

