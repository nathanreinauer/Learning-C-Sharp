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

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5-3 =" + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5/3 =" + (5 / 3));
            Console.WriteLine("5.2%3="+(5.2%3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i =" + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i =" + (--i));

            Console.WriteLine("i+=3" + (i+=3));
            Console.WriteLine("i-=2" + (i-=2));
            Console.WriteLine("i*=2" + (i*=2));
            Console.WriteLine("i/=2" + (i/=2));
            Console.WriteLine("i%=2" + (i%=2));
            

        }
    }
}
