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
            printMatrix();

            Console.ReadLine();
        }
        public static void printMatrix()
        {
            int[,] matrix = new int[5, 5];

            int i, j;

            for (i = 0; i < 5; i++) 
                for (j = 0; j < 5; j++)
                { 
                    if (i == j) matrix[i, j] = 0;
                    else if (i > j) matrix[i, j] = -1;
                    else matrix[i, j] = 1;
                }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                    Console.Write("{0}\t", matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}