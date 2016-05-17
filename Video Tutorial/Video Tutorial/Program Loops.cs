using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double GetSum(double num1, double num2);

namespace Video_Tutorial
{



    class Animal
    {
        static void Main(string[] args)
        {
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;

            };

            Console.WriteLine("5 + 10 =" + sum(5, 10));
        }
    }
}