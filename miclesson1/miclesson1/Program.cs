using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miclesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nshel erkarutyun: ");
            int erkarutyun = int.Parse(Console.ReadLine());
            Console.Write("Nshel laynutyun: ");
            int laynutyun = int.Parse(Console.ReadLine());
            int Paragic = (erkarutyun + laynutyun)*2;
            int Makeres = erkarutyun * laynutyun;
            string result = "Paragicy:"+ Paragic+"  Makeresy: "+Makeres;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.SetCursorPosition((Console.WindowWidth - result.Length) / 2, Console.CursorTop);
            Console.WriteLine(result);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < erkarutyun; i++ )
            {
                if (i == 0 || i < (laynutyun))
                {
                    for (int j = 0; j < erkarutyun; j++ )
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.ReadLine();
            //string zig = "you Can do  this application in  two  days";
            //char[] chArray = zig.ToCharArray();

            //Array.Reverse(chArray);

            //foreach (char zigChar in chArray)
            //    Console.Write(zigChar);
            //Console.ReadLine();
            Console.Write("Nshel zangvaci chapy: ");
            int lenghtOfArray = int.Parse(Console.ReadLine());
            int[] makedArray = new int[(lenghtOfArray+1)];
            Random rnd = new Random();
            //Console.WriteLine(rnd.Next(-99,100));

            for (int i = 0; i <  lenghtOfArray ; i++)
            {

                makedArray[i] = rnd.Next(-99,100);
                Console.WriteLine("index - "+i+" "+ "Arjeq - "+ makedArray[i]);
            }
            Console.ReadLine();

        }

    }
}
