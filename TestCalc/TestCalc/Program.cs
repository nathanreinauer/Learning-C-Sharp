using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            do
            {
                Console.WriteLine(
                    "Press 'a' for addition, 's' for subtraction, 'm' for multiplication, 'd' for division, or 'e' for exit."
                    );

                string entry = Console.ReadLine().ToLower();

                if (entry == "e")
                {
                    Console.WriteLine("See ya.");
                    Console.ReadLine();
                    break;
                }
                else if (entry == "a")
                {
                    AddIt();
                    continue;
                }
                else if (entry == "s")
                {
                    SubIt();
                    continue;
                }
                else if (entry == "m")
                {
                    MultIt();
                    continue;
                }
                else if(entry == "d")
                {
                    DivIt();
                    continue;
                }
                else
                {
                    Console.WriteLine("I didn't get that.");
                    continue;
                }
            } while (true);
        }

        static void AddIt()
        {
            Console.WriteLine("Enter the first number.");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine(numA + numB);
        }

        static void SubIt()
        {
            Console.WriteLine("Enter the first number.");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine(numA - numB);
        }

        static void MultIt()
        {
            Console.WriteLine("Enter the first number.");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine(numA * numB);
        }

        static void DivIt()
        {
            Console.WriteLine("Enter the first number.");
            double numA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            double numB = double.Parse(Console.ReadLine());
            Console.WriteLine(numA / numB);
        }
    }
}
