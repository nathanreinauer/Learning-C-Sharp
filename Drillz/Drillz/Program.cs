
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drillz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for 'a'.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a different value for 'b'.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a different value for 'c'.");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} (a) is the largest number.", a);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("{0} (b) is the largest number.", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("{0} (c) is the largest number.", c);
            }
            else
            {
                Console.WriteLine("You did not enter different values!");
            }
        }
    }
}