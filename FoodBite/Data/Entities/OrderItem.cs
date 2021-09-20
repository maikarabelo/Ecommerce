using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FoodBite.Data.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
