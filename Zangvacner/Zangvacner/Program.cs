using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zangvacner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int sizeOfArray = int.Parse(Console.ReadLine());
            //Console.WriteLine(n);
            Random rd = new Random();
            // double number = rd.NextDouble();
            //Console.WriteLine(number);
            //(maximum - minimum) + minimum;
            double[] doubleArray = new double[sizeOfArray];
            Console.WriteLine("arajadranq 1.a");
            for (int i = 0; i < sizeOfArray; i++)
            {
                double number = rd.NextDouble() * 100;
                if (number <100 && number >10 && number != 0)
                {
                    doubleArray[i] = number;
                    
                }
                Console.WriteLine(doubleArray[i]);

            }
            Console.WriteLine("arajadranq 1.b");
            bool isOdd = false;
            foreach (var doubleA in doubleArray)
            {
                if (isOdd)
                {
                    Console.WriteLine(doubleA);
                    isOdd = false;
                }
                else
                {
                    isOdd = true;
                }
                    
            }
            Console.WriteLine("arajadranq 1.c");
            foreach (var doubleA in doubleArray)
            {
                if (Math.Truncate(doubleA
                    ) % 2 == 0)
                {
                    Console.WriteLine(doubleA);
                }
            }

            Console.WriteLine("arajadranq 1.d");
            Console.WriteLine(doubleArray.Min());
            Console.ReadLine();
        }
        
    }
}
