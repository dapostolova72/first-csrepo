using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача._1.Обработка_на_масив
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete posledovatelno masiva ot stringove");
                    string[] masiv = Console.ReadLine().Split();
            Console.WriteLine("Vavedete broi komandi");
                    int n = int.Parse(Console.ReadLine());

               for(int i=0;i<n;i++)
            {
                        Console.WriteLine("vavedete komanda");
                        string[] command = Console.ReadLine().Split();
                        switch (command[0].ToLower())
                        {
                            case "reverse":
                                Array.Reverse(masiv);
                                break;
                            case "distinct":
                                masiv = masiv.Distinct().ToArray();
                                break;
                            case "replace":
                                int index = int.Parse(command[1]);
                                string newWord = command[2];
                                masiv[index] = newWord;
                                break;
                        }
                    }

                    Console.WriteLine(string.Join(" ", masiv));
                }
            }
        }

           