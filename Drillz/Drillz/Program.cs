
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
            Console.WriteLine("Enter the quiz score.");
            float quiz = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mid-term score.");
            float midTerm = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the final score.");
            float final = float.Parse(Console.ReadLine());

            float score = (quiz + midTerm + final) / 3;
            if (score >= 90)
            {
                Console.WriteLine("Overall grade is A.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Overall grade is B.");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Overall grade is C.");
            }
            else
            {
                Console.WriteLine("Overall grade is F.");
            }
        }
    }
}