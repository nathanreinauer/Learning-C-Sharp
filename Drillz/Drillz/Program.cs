﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drillz
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.Write("Pascal triangle size:");

            size = Int32.Parse(Console.ReadLine());

            printPascalTr(size);

            Console.ReadLine();
        }
        public static void printPascalTr(int size)
        {
            int[,] PascalTr = new int[size, size];
            int row, col;

            for (row = 0; row < size; row++)
                for (col = 0; col < size; col++) PascalTr[row, col] = 0;

            PascalTr[0, 0] = 1;

            PascalTr[1, 0] = 1;

            PascalTr[1, 1] = 1;

            for (row = 2; row < size; row++)
            {
                PascalTr[row, 0] = 1;

                for (col = 1; col <= row; col++)
                {
                    PascalTr[row, col] = PascalTr[row - 1, col - 1] + PascalTr[row - 1, col];
                }
            }

            for (row = 0; row < size; row++)
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write("{0}\t", PascalTr[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}