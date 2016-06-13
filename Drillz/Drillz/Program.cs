
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
            int i, j;
            for (i = 0; i <= 6; i++)
            {
                for (j = 1; j <= 7 - i; j++) Console.Write("*");
                Console.WriteLine("\n");
            }
        }
    }
}