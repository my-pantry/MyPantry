using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPantry.Models;

namespace MyPantry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dashboard() 
        {
            return View();
        }

        public IActionResult Person() {
            var person = new Person() {Id = 1, FirstName = "Donelle", LastName = "Harris", Email = "DonelleHarris@Somewhere.com", Password = "password"};
            ViewData["person"] = person;
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult GroceryItem()
        {
            var groceryItem = new GroceryItem() {Id = 1, Name = "Flour", PurchaseDate = DateTime.Now.ToString("dd.MM.yyyy"), ExpirationDate = "05/01/2021", Quantity = 1, Barcode = "10101000100010"};
            ViewData["groceryItem"] = groceryItem;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
