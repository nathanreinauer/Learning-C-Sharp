using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Drill_1
{
    public class Example
    {
        public int add(int first, int second, int third)
        {
            return first + second + third;
        }
        public int add(int first, int second)
        {
            return first + second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example adding = new Example();
            Console.WriteLine(adding.add(1,1,1));
            Console.WriteLine(adding.add(1,2));
        }
    }
}
