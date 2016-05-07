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
            string randString = "Here are some random characters";

            foreach (char c in randString)
            {
                Console.WriteLine(c);
            }
           
        }
    }
}
