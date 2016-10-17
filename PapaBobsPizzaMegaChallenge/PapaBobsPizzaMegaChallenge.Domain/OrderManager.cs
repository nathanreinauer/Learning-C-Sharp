using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsPizzaMegaChallenge;

namespace PapaBobsPizzaMegaChallenge.Domain
{
    public class OrderManager
    {
        public static List<DTO.Order> GetOrders()
        {
            var orders = Persistence.OrderRepository.GetOrders();
            return orders;
        }

        public static void AddOrder(DTO.Order order)
        {
            Persistence.OrderRepository.AddOrder(order);
        }
    }
}
