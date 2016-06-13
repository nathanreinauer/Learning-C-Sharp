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
            bool found = false;
            int[] arr = new int[10]
            {
                23, 2, 3, 34, 6,1,24,45,78,8
            };

            int length = arr.Length;

            Console.WriteLine("Choose a number to search for:");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("Your number is at position {0}.", i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Number not found.");
            }

        }
    }
}