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

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to elementary school");
            }


        }
    }
}
