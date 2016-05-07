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

            int i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }

                if (i == 9)
                {
                    break;
                }

                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            
            }
           
        }
    }
}
