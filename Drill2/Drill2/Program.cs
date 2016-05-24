using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill2
{
    class one
    {
        public int number()
        {
            return 1;
        }
         //Public: This can be used anywhere
    }
    class two
    {
        private int number2()
        {
            return 1;
        }
        //Private: This can only be used in "class two"
    }
    class three
    {
        protected int number3()
        {
            return 1;
        }
        //This can be used in any class derived from this base class
    }
    class four
    {
        internal int number4()
        {
            return 1;
        }
        //This can only be used in this assembly and this class
    }
    class five
    {
        internal protected int number5()
        {
            return 1;
        }
        //This can be used anywhere in this assembly
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
