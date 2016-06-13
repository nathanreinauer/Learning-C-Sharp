
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
            bool run = true;

            while (run)
            {
                Console.WriteLine("What is the command keyword to exit a loop in C#?");
                Console.WriteLine("a. int");
                Console.WriteLine("b. continue");
                Console.WriteLine("c. break");
                Console.WriteLine("d. exit");

                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "a": Console.WriteLine("Incorrect."); break;
                    case "b": Console.WriteLine("Incorrect."); break;
                    case "c": Console.WriteLine("Correct!"); run = false; break;
                    case "d": Console.WriteLine("Incorrect!"); break;
                    default: Console.WriteLine("Invalid input."); break;
                }
            }
        }
    }
}