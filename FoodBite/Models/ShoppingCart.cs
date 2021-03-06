using FoodBite.Data;
using FoodBite.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Models
{
    public class ShoppingCart
    {
        private readonly FoodbiteContext _foodbiteDbContext;

        public string ShoppingCartId { get; set; }

        public List<Order> Orders { get; set; }

        private ShoppingCart(FoodbiteContext foodbiteDbContext)
        {
            _foodbiteDbContext = foodbiteDbContext;
        }

          public static ShoppingCart GetCart(IServiceProvider services)
          {
              ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                  .HttpContext.Session;

              var context = services.GetService<FoodbiteContext>();

              string cartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

              session.SetString("cartId", cartId);

              return new ShoppingCart(context) { ShoppingCartId = cartId };
          }

          public void AddToCart(Product product, int amount)
          {
              var shoppingCartItem =
                      _foodbiteDbContext.Orders.SingleOrDefault(
                          s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

              if (shoppingCartItem == null)
              {
                  shoppingCartItem = new Order
                  {
                      ShoppingCartId = ShoppingCartId,
                      Product = product,
                      Amount = 1
                  };

                  _foodbiteDbContext.Orders.Add(shoppingCartItem);
              }
              else
              {
                  shoppingCartItem.Amount++;
              }
              _foodbiteDbContext.SaveChanges();
          }

          public int RemoveFromCart(Product product)
          {
              var shoppingCartItem =
                      _foodbiteDbContext.Orders.SingleOrDefault(
                          s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

              var localAmount = 0;

              if (shoppingCartItem != null)
              {
                  if (shoppingCartItem.Amount > 1)
                  {
                      shoppingCartItem.Amount--;
                      localAmount = shoppingCartItem.Amount;
                  }
                  else
                  {
                      _foodbiteDbContext.Orders.Remove(shoppingCartItem);
                  }
              }

              _foodbiteDbContext.SaveChanges();

              return localAmount;
          }

          public List<Order> GetShoppingCartItems()
          {
              return Orders ??
                     (Orders =
                         _foodbiteDbContext.Orders.Where(c => c.ShoppingCartId == ShoppingCartId)
                             .Include(s => s.Product)
                             .ToList());
          }

          public void ClearCart()
          {
              var cartItems = _foodbiteDbContext
                  .Orders
                  .Where(cart => cart.ShoppingCartId == ShoppingCartId);

              _foodbiteDbContext.Orders.RemoveRange(cartItems);

              _foodbiteDbContext.SaveChanges();
          }

          public decimal GetShoppingCartTotal()
          {
              var total = _foodbiteDbContext.Orders.Where(c => c.ShoppingCartId == ShoppingCartId)
                  .Select(c => c.Product.ProductPrice * c.Amount).Sum();
              return total;
          }
     }
}

  
