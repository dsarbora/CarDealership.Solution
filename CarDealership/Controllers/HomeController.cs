using Dealership.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Dealership.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/newcar")]
        public ActionResult Create(string makeModel, int price, int miles)
        {
            Car newCar = new Car(makeModel, price, miles);
            return RedirectToAction("Inventory");
        }

        [HttpGet("/inventory")]
        public ActionResult Inventory()
        {
            List<Car> newList = Car.GetList();
            return View(newList);
        }
    }
}