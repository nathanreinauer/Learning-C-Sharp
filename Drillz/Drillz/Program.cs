
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
                    Console.WriteLine("Press 'y' to play again.");
                    random = rand.Next(1, 10);
                    play = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nope! Try again.");               
                }
            } while (play == "y");
        }
    }
}