using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            string guess;
            do
            {
                Console.WriteLine("Guess a number ");
                guess = Console.ReadLine();



            } while (!guess.Equals("15"));
           
        }
    }
}
