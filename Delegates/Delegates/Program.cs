using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Del(string message);

        public static void DelMethod(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Del helloMessage = DelMethod;
            helloMessage("Hello!");

        }
    }
}
