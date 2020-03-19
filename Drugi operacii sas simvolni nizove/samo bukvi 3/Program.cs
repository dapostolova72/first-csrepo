using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samo_bukvi_3
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var timer = new Stopwatch();
          //  timer.Start();
            Console.WriteLine("Vavedete tekst");
            string text = Console.ReadLine();
            List<char> duma = new List<char>();
            string chisla = "";
            int k = 0;
            for (int i = 0; i < text.Length; i++)

            {
                duma.Add(text[i]);
                 }
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if ((int)duma[i] >= 43 && (int)duma[i] <= 57)
                {
                    text = text.Replace(text[i], '0');
                   
                 }
                                               
            }
            Console.WriteLine(text);

            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == '0'&& text[i+1]=='0')
                {
                    chisla = chisla + duma[i];
                    k = i;
                 //  Console.WriteLine("Poziciata na chisloto e " + k);
                    int n = chisla.Length;
                   // Console.WriteLine("Broia na chislata e= " + n);
                 //  Console.WriteLine("chisla sa" + chisla);
                                    
                    text = text.Replace(text[k], text[k + 1]);
                     text = text.Remove(k + 1, 1);
                        
                   // Console.WriteLine(" Teksta s premahnato chislo e " + text);
                    

                } 
            }
                                 
            string last = "";
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
               
                if (text[i]=='0')
                {
                    if (last !="")
                    {
                       
                        result += last;
                    }
                    else
                        result += text[i].ToString();
                }
                else
                {
                    last = text[i].ToString();
                   
                    result += text[i].ToString();
                }
            }
            Console.WriteLine(string.Join("", result.Reverse()));

            //Console.WriteLine(timer.Elapsed);

           



        }
                   
            }
           
        }
    

              