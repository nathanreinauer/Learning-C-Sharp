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

            string sampleString = "A bunch of random words";

            Console.WriteLine("Index of bunch " +sampleString.IndexOf("bunch"));

            Console.WriteLine("2nd Word " + sampleString.Substring(2, 6));

            string sampString2 = "More random words";

            Console.WriteLine("Strings equal " + sampleString.Equals(sampString2));

            Console.WriteLine("Starts with \"A bunch\"" + sampleString.StartsWith("A bunch"));

            Console.WriteLine("Ends with " + sampleString.EndsWith("words"));


        }
    }
}
