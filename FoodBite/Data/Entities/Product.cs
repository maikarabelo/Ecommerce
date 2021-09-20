using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FoodBite.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        
        
    }
}
