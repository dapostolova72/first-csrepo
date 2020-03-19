using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samo_bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete tekst");
            string text = Console.ReadLine();
            List<char> duma = new List<char>();
            string chisla ="";
            int k = 0;
            for (int i = 0; i < text.Length; i++)
                    
            {
                    duma.Add(text[i]);
                            
                   }
            for (int i=  text.Length-1;i>=0; i--)
            {
                if((int)duma[i]>=43 && (int)duma[i]<=57)
                { 
                    chisla = chisla + duma[i];
                     k = i;
                    Console.WriteLine("k"+k);
                    int n = chisla.Length;
                    Console.WriteLine("Broia na chislata e= "+n);

                     if (n == 1)
                    { text = text.Replace(text[i],text[i+1]);
                        Console.WriteLine(" Teksta s podmeneni simvoli " + text);                    }

                    if (n > 1)
                    {

                        Console.WriteLine("chisla sa" + chisla);
                        text = text.Remove(k, n - 1);
                        Console.WriteLine(" Teksta s premahnato chislo e" + text);
                    }
                   
                    



                }




            }



            Console.WriteLine(" Teksta bez chisla " + text);


            for (int i = text.Length - 1; i >= 0; i--)
            {
                if ((int)text[i] >= 43 && (int)text[i] <= 57)
                {

                    text = text.Replace(text[i], text[i + 1]);
                }
            }
            Console.WriteLine(" Teksta s podmeneni simvoli " + text);


        }
    }
}