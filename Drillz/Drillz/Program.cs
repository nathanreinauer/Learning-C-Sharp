
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
            int x = 10;
            int y = 5;
            Console.WriteLine("x = {0}", x = y + 3);
            Console.WriteLine("x = {0}", x = y - 2);
            Console.WriteLine("x = {0}", x = y * 5);
            x = 10;
            Console.WriteLine("x = {0}", x = x / y);
            x = 10;
            Console.WriteLine("x = {0}", x = x % y);

        }
    }
}