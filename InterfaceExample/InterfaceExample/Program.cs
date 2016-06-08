using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IHello
    {
        string printHello();
    }
    class Hello : IHello
    {
        public string printHello()
        {
            Console.WriteLine("Hello!");
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello hi = new Hello();
            hi.printHello();
        }
    }
}
