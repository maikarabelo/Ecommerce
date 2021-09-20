using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBite.Data.Entities
{
    public class OrderRequest
    {
        public int OrderRequestId { get; set; }
        public string PersonName { get; set; }
        public int RequestPhone { get; set; }
        public string RequestEmail { get; set; }
        public string Message { get; set; }

        
    }
}
