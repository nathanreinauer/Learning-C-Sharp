using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = "I enjoy writing uber-software in C#";

            var results = from c in sample.ToLower()
                          where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                          orderby c
                          group c by c;
                          

            foreach (var item in results)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }
        }
    }
}
