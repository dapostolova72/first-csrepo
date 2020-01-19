using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Chas na izpita");
            int chas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Minuti na izpita");
            int minuti = int.Parse(Console.ReadLine());
            // Console.WriteLine("Chas na pristigane na studenta");
            int chasstudent = int.Parse(Console.ReadLine());
            // Console.WriteLine("Minuti na pristigane na studenta");
            int minutistudent = int.Parse(Console.ReadLine());

            


          
            //zakasnenie
            if (chasstudent*60+minutistudent >= chas*60+minuti)
            {
                if (chas == chasstudent && minuti == minutistudent)
                { Console.WriteLine("On time"); }
                else
                if (chasstudent * 60 - chas * 60 < 60)//zakasnenieto e do chas
                {
                    Console.WriteLine("Late");
                   
                     Console.WriteLine(minutistudent - minuti + " minutes after the start"); 
                }

                if (chasstudent * 60 - chas * 60 >= 60)//zakasnial poveche ot chas
                {
                    if (minutistudent <= minuti)
                    {
                        double minuti2 = (chasstudent * 60 + minutistudent) - (chas * 60 + minuti);
                        if (minuti2 >= 60)
                        {
                            double chastno = Math.Floor(minuti2 / 60);
                            double ostatak = minuti2 % 60;
                            Console.WriteLine("Late");
                            if (ostatak < 10)
                            { Console.WriteLine((chastno) + ":0" + ostatak + " hours after the start"); }
                            else { Console.WriteLine((chastno) + ":" + ostatak + " hours after the start"); }
                        }
                        else
                        {
                            Console.WriteLine("Late");
                            if (minuti2 < 10)
                            { Console.WriteLine("0" + minuti2 + " minutes after the start"); }
                            else
                            {
                                Console.WriteLine(minuti2 + " minutes after the start");
                            }


                        }


                    }
                    else
                    {
                        Console.WriteLine("Late");
                        if ((minutistudent - minuti) < 10)
                        { Console.WriteLine((chasstudent - chas) + ":0" + (minutistudent - minuti) + " hours after the start"); }
                        else { 
                        Console.WriteLine((chasstudent - chas) + ":" + (minutistudent - minuti) + " hours after the start");
                    }
                    }


                }
            }


            else
            //nawreme do 30 minuti
            if (chas * 60 + minuti <= (chasstudent * 60 + minutistudent + 30))
            {
                Console.WriteLine("On time");
                double chas2 = chas * 60 + minuti - (chasstudent * 60 + minutistudent);
                double chasearly = Math.Floor(chas2 / 60);
                double minutiearly = chas2 % 60;
                Console.WriteLine(minutiearly + " minutes before the start ");



            }

            else
            
                if (chas * 60 + minuti - (chasstudent * 60 + minutistudent) >= 60)
                {
                    double chas2 = chas * 60 + minuti - (chasstudent * 60 + minutistudent);
                    double chasearly = Math.Floor(chas2 / 60);
                    double minutiearly = chas2 % 60;
                    Console.WriteLine("Early ");
                    if (minutiearly < 10)
                    { Console.WriteLine(chasearly + ":0" + minutiearly + " hours before the start"); }
                    else
                    { Console.WriteLine(chasearly + ":" + minutiearly + " hours before the start"); }
                }
                else
                {
                    Console.WriteLine("Early");
                    double chas2 = chas * 60 + minuti - (chasstudent * 60 + minutistudent);
                    double chasearly = Math.Floor(chas2 / 60);
                    double minutiearly = chas2 % 60;

                    Console.WriteLine(minutiearly + " minutes before the start");

                }
            }
        }
    }
























