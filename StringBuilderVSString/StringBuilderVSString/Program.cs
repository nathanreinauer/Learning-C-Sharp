using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderVSString
{
    class Program
    {
        static void Main(string[] args)
        {
            // A string is immutable. It represents one memory location and can't change.
            string myString = "Goodbye!";
            Console.WriteLine(myString);

            // A StringBuilder is mutable and can be changed and added to.
            StringBuilder myStringBuilder = new StringBuilder("Hello! ");
            myStringBuilder.Append(myString);
            Console.WriteLine(myStringBuilder);

        }
    }
}
