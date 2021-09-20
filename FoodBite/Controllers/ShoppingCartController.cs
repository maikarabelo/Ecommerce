using FoodBite.Data;
using FoodBite.Models;
using FoodBite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodRepository foodRepository, ShoppingCart shoppingCart)
        {
            _foodRepository = foodRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.Orders = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _foodRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _foodRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
    }
}
