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
            int[] arr = { 42, 11, 54, 700, 32, 659, 240, 9 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
        }
    }
}