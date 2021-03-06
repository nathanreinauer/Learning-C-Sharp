﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizzaMegaChallenge.DTO
{
    public class Order
    {
        public System.Guid OrderId { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public bool PaymentType { get; set; }
        public bool Completed { get; set; }

    }
}
