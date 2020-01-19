using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zala
    {
       
        class TrainingLab
        {
            static void Main()
            {
                var width = double.Parse(Console.ReadLine()) * 100;
                var height = double.Parse(Console.ReadLine()) * 100;

                var cols = Math.Floor((height - 100) / 70);
                var rows = Math.Floor(width / 120);
                var seats = rows * cols - 3;
                Console.WriteLine(seats);
            }
        }
         
    }
}


