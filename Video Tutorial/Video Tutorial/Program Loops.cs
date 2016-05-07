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

            string sampString = "A bunch of random words";

            string sampString2 = "More random words";

            sampString = sampString.Replace("words", "characters");

            sampString = sampString.Remove(0, 2);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List " + String.Join(", ", names));

            


        }
    }
}
