
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
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");
            Console.WriteLine("a. int 1x=10;");
            Console.WriteLine("b. int x=10;");
            Console.WriteLine("c. float x=10.0f;");
            Console.WriteLine("d. string x=\"10\";");

            var answer = Console.ReadLine();
            
            switch (answer)
            {
                case "a": Console.WriteLine("Incorrect."); break;
                case "b": Console.WriteLine("Correct!"); break;
                case "c": Console.WriteLine("Incorrect."); break;
                case "d": Console.WriteLine("Incorrect."); break;
                default: Console.WriteLine("Invalid input."); break;
            }   
        }
    }
}