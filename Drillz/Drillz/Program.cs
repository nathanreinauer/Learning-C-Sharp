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
            Console.WriteLine("Choose a number to search for.");
            int input = int.Parse(Console.ReadLine());

            int[] arr = new int[10]
            {
                23, 2, 3, 34, 6, 1, 24, 45, 78, 8
            };
            int[] arr2 = arr.OrderBy(x => x).ToArray();
            Console.WriteLine("Found {0} at position {1}.", input, BinarySearchIterative(arr2, input, 0, arr.Length));
        }
        public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "Nil";
        }
    }
}