using FoodBite.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Data
{
    public class FoodRepository : IFoodRepository
    {
        private readonly FoodbiteContext _ctx;
        private readonly ILogger<FoodRepository> _logger;

        public FoodRepository(FoodbiteContext ctx, ILogger<FoodRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }
        public IEnumerable<Product>GetAllProducts()
        {
            try
            {
                _logger.LogInformation("GetAllProducts was called");
                return _ctx.Products.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
           
        }


        public bool SaveChanges()
        {
            return _ctx.SaveChanges() > 0;
        }



    }
}
