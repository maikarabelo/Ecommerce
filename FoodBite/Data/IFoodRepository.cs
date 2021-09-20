using FoodBite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Data
{
    public interface IFoodRepository
    {
        IEnumerable<Product> GetAllProducts();
        bool SaveChanges();
    }

   
}
