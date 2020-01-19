using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Въвеждане_на_масив_от_един_ред
{
    class Program
    {
        static void Main(string[] args)
        {
            var razdelitel = Console.ReadLine();//Ot klaviaturata cheti string
            //Split razdelitel
           string[] masiv = razdelitel.Split(' ');//syzdaj masiv ot stringove kato za razdelitel izpolzvash intervala 
            

            int[] arr = masiv.Select(int.Parse).ToArray();//izberi celite chisla ot masiva i gi slovi v nov masiv arr
            Console.Write(string.Join(" ",arr));
            

        }
    }
}
