using FoodBite.Data;
using FoodBite.Models;
using FoodBite.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Controllers
{
    public class AppController: Controller
    {
        private readonly IMailService _mailService;
        private readonly IFoodRepository _repository;

        public AppController(IMailService mailService, IFoodRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }
        public IActionResult Index()
        {
            //throw new InvalidProgramException("Bad things happen to good developers");
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {

                //send email
                _mailService.SendMessage("karabo@tshimologong.joburg", model.Phone, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                   ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
           
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult Shop()
        {

            var results = _repository.GetAllProducts();

            return View(results);
        }
        public IActionResult _FoodCart()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult login()
        {
            ViewBag.Title = "Login";
            return View();
        }

        public IActionResult register()
        {
            ViewBag.Title = "Register";
            return View();
        }
    }
}
