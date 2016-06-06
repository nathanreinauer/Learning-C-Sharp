using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "We want to write this to our file.";

            File.WriteAllText(@"C:\Users\Student\Desktop\WriteText.txt", text);
            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
