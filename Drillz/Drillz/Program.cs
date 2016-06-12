
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
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("The value of a is {0}.", a);
            Console.WriteLine("...............");
            Console.WriteLine("The value of a is {0}.", ++a);
            Console.WriteLine("The value of a is {0}.", a);
            Console.WriteLine("The value of a is {0}.", a++);
            Console.WriteLine("The value of a is {0}.", a);
            Console.WriteLine("The value of a is {0}.", --a);
            Console.WriteLine("The value of a is {0}.", a);
            Console.WriteLine("The value of a is {0}.", a--);
            Console.WriteLine("The value of a is {0}.", a);

        }
    }
}