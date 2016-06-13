
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
            string choice;
            string con = "y";
            Console.WriteLine("a.quit");
            Console.WriteLine("b.continue");
            Console.WriteLine("c.break");
            Console.WriteLine("d.exit");

            do
            {
                Console.Write("What is the command keyword to exit a loop in C#?");
                choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.WriteLine("Correct!");
                }
                else Console.WriteLine("Incorrect.");
                Console.Write("Press 'y' to play again.");
                con = Console.ReadLine().ToString();
            } while (con == "y");
        }
    }
}