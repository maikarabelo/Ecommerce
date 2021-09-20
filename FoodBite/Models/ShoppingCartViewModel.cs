using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodBite.Models;

namespace FoodBite.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
