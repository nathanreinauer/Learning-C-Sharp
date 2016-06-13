
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
            string play = "y";
            Random rand = new Random();
            int random = rand.Next(1, 10);

            do
            {
                Console.WriteLine("Guess a random number between 1 and 10.");
                int guess = int.Parse(Console.ReadLine());
                if (guess == random)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Nope. Enter 'y' to try again.");
                    play = Console.ReadLine();
                }


            } while (play == "y");
        }
    }
}