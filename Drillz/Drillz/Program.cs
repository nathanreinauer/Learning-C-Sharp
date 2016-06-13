using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drillz
{
    class Program
    {
        static void Main(string[] args)
        {
            printArray();

            Console.ReadLine();
        }

        public static void printArray()
        {
            int[,] tArr = new int[5, 5];

            int i, j;

            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    if (i == 0) tArr[i, j] = j + 1;
                    else if (i > 0 && j == 0)

                        tArr[i, j] = tArr[i - 1, 4] + 1;
                    else
                        tArr[i, j] = tArr[i, j - 1] + 1;
                }

            for (i = 0; i < 5; i++)
            { 
                for (j = 0; j < 5; j++)
                    Console.Write("{0}\t", tArr[i, j]);

                Console.WriteLine();
            }
        }
    }
}