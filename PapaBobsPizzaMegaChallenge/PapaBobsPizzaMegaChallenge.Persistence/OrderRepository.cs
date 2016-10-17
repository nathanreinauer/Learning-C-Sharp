using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizzaMegaChallenge.Persistence
{
    public class OrderRepository
    {
        public static List<DTO.Order> GetOrders()
        {
            PapaEntities db = new PapaEntities();
            var dbOrders = db.Orders.OrderBy(p => p.OrderId).ToList();

            var dtoOrders = new List<DTO.Order>();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.Order();

                dtoOrder.OrderId = dbOrder.OrderId;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = dbOrder.Sausage;
                dtoOrder.Pepperoni = dbOrder.Pepperoni;
                dtoOrder.Onions = dbOrder.Onions;
                dtoOrder.GreenPeppers = dbOrder.GreenPeppers;
                dtoOrder.TotalCost = dbOrder.TotalCost;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.Zip = dbOrder.Zip;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.PaymentType = dbOrder.PaymentType;
                dtoOrder.Completed = dbOrder.Completed;

                dtoOrders.Add(dtoOrder);
            }

            return dtoOrders;
        }

        public static void AddOrder(DTO.Order newOrder)
        {
            PapaEntities db = new PapaEntities();
            var dbOrders = db.Orders;

            var order = new Order();

            if (newOrder.Name.Trim().Length == 0)
                throw new Exception("Name is a required field.");
            if (newOrder.Address.Trim().Length == 0)
                throw new Exception("Address is a required field.");
            if (newOrder.Phone.Trim().Length == 0)
                throw new Exception("Phone Number is a required field.");

            order.OrderId = newOrder.OrderId;
            order.Size = newOrder.Size;
            order.Crust = newOrder.Crust;
            order.Sausage = newOrder.Sausage;
            order.Pepperoni = newOrder.Pepperoni;
            order.Onions = newOrder.Onions;
            order.GreenPeppers = newOrder.GreenPeppers;
            order.TotalCost = newOrder.TotalCost;
            order.Name = newOrder.Name;
            order.Address = newOrder.Address;
            order.Zip = newOrder.Zip;
            order.Phone = newOrder.Phone;
            order.PaymentType = newOrder.PaymentType;
            order.Completed = newOrder.Completed;

            try
            {
                dbOrders.Add(order);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the exception.

                throw ex;
            }

        }
    }
}
