using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2School_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops

            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while (i < 10);

           for (int i = 0; i < 9; i++)
           {
               if (i ==4)
               {
                    //break;
                    continue;
               }
                Console.WriteLine(i);
           }


            // for (int i = 0; i <= 720; i = i + 20)
            //{
            //      Console.WriteLine(i);

            //string[] peopleIDontReallyLike = { "You", "Myself", "Simon Cowell" };
           // foreach (string i in peopleIDontReallyLike)
               // Console.WriteLine("People I dont really like: " + i);

          Console.ReadKey(true);  

               
        }
    }
}
