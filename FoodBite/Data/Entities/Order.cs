using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FoodBite.Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Amount { get; set; }
        public  OrderRequest OrderRequest { get; set; }
        public Product Product { get; set; }
        public OrderItem OrderItem { get; set; }
        public string ShoppingCartId { get; set; }


    }
}
