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
            int n;
            float mean, median, std;
            Console.Write("Enter number of data points:");
            n = int.Parse(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine("The number of data points should be greater than 2.");
            }
            else
            {
                int[] dataset = new int[n];

                int i = 0;
                for (i = 0; i < n; i++)
                {
                    Console.Write("[{0}]:", i);
                    dataset[i] = int.Parse(Console.ReadLine());
                }

                bubblesort(dataset, n);

                int sum = 0;
                int j = 0;
                while (j < n)
                {
                    sum = sum + dataset[j];
                    j++;
                }
                mean = (float)sum / n;
                if (n % 2 != 0) median = dataset[n / 2];
                else median = (dataset[(n / 2) - 1] + dataset[n / 2]) / (float)2;

                int[,] mode = new int[n, 2];
                for (i = 0; i < 2; i++)
                    for (j = 0; j < n; j++) mode[j, i] = 0;
                mode[0, 0] = 1;

                for (i = 0; i < n; i++)
                    for (j = 0; j < n - 1; j++)
                        if (dataset[i] == dataset[j + 1]) { ++mode[i, 0]; mode[i, 1] = dataset[i]; }

                int max;
                int k = 0;
                max = mode[0, 0];
                for (j = 0; j < n; j++)
                    if (max < mode[j, 0]) { max = mode[j, 0]; k = j; }

                float temp = 0.0f;

                for (j = 0; j < n; j++)
                {
                    temp = temp + (float)Math.Pow(dataset[j] - mean, 2);
                }
                std = (float)Math.Sqrt(temp / (n - 1));

                Console.WriteLine("Statistical Information:");
                Console.WriteLine("Arithmetic mean:{0}", mean);
                Console.WriteLine("Median:{0}", median);
                if (mode[k, 1] != 0)
                    Console.WriteLine("Mode:{0}", mode[k, 1]);
                else Console.WriteLine("Mode: no mode");
                Console.WriteLine("Standard deviation:{0}", std);
            }
            Console.ReadLine();
        }
        static void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j] < dataset[j - 1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }
        }
    }
}