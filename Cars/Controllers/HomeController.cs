using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/list")]
    public ActionResult List()
    {
      string model = Request.Query["new-model"];
      int price = int.Parse(Request.Query["new-mileage"]);
      int miles = int.Parse(Request.Query["new-price"]);
      string color = Request.Query["new-color"];
      Car newCar = new Car(model,price,miles,color);
      newCar.Save();
      return View(Car.GetCars());
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}
