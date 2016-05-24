using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Math
    {
        public virtual int operation(int first, int second)
        {
            return first + second;
        }

    }
    public class MoreMath : Math
    {
        public override int operation(int first, int second)
        {
            return first - second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new MoreMath();
            int x = math.operation(5, 2);
            Console.WriteLine(x);
        }
    }
}
