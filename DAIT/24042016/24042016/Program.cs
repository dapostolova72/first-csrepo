using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24042016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char znak = char.Parse(Console.ReadLine());
            if (znak == '+')
            {
                int rezult = n1 + n2;
                if (rezult % 2 == 0)
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-even"); }
                else
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-odd"); }
            }
            if (znak == '-')
            {
                int rezult = n1 - n2;
                if (rezult % 2 == 0)
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-even"); }
                else
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-odd"); }
            }
            if (znak == '*')
            {
                int rezult = n1 * n2;
                if (rezult % 2 == 0)
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-even"); }
                else
                { Console.WriteLine($"{n1}{znak}{ n2}={rezult}-odd"); }
            }
            if (znak == '/')
            {

                if (n2 == 0)
                { Console.WriteLine($"Cannot divide {n1} by zero"); }
                else
                {
                    
                    Console.WriteLine($"{n1} / {n2} = {(double)n1 / n2}");
                }
                   
                   
                }
            

                if (znak == '%')
                {

                    if (n2 == 0)
                    { Console.WriteLine($"Cannot divide {n1} by zero"); }
                    else
                    {
                        int rezult = n1 % n2;
                        
                        Console.WriteLine($"{n1}{znak}{n2}={rezult}"); 
                     
                    }
                }
            }
        }
    }

