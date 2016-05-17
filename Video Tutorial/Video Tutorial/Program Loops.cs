using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Tutorial
{

    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i)
        {

            name = n;
            balance = b;
            id = i;

        }

        public void showCust()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("Id " + id);
        }
    }

    class Animal
    {

        static void Main(string[] args)
        {

            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();


        }
    }
}