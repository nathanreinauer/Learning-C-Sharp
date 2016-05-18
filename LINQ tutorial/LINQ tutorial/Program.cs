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
            var people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Age = 25},
                new Person { FirstName = "Jane", LastName = "Doe", Age = 26},
                new Person { FirstName = "John", LastName = "Williams", Age = 40},
                new Person { FirstName = "Samantha", LastName = "Williams", Age = 35},
                new Person { FirstName = "Bob", LastName = "Walters", Age = 12},
            };

            var results = from p in people
                          orderby p.LastName descending
                          group p by p.LastName;
                          

            foreach (var item in results)
            {
                Console.WriteLine(item.Key);
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}", p.LastName, p.FirstName);
                }
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
