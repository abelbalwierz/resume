using CarDealership.Models;
using CarDealership.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {
        ICarRepository _repo = new MockCarRepository();

        // GET: Car
        public ActionResult Index()
        {
            var cars = _repo.GetAllCars();
            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var car = _repo.GetCarById(id);
            return View(car);
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Enter a new car for sale using the form below!";
            return View(new Car());
        }

        [HttpPost]
        public ActionResult Add(Car newCar)
        {
            ViewBag.Message = "Enter a new car for sale using the form below!";

            if (ModelState.IsValid)
            {
                _repo.AddCar(newCar);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Add");
            }
        }
       
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Details2(string Year, string Make, string Model)
        {
            Car carView = _repo.GetCarByMMY(Year, Make, Model);
            if (carView == null)
            {
                return RedirectToAction("Index");
            }
            return View("Details", carView);
        }

    [HttpPost]
        public ActionResult LoginUser(string username, string password)
        {
            var user = _repo.LoginUser(username, password);
            ViewBag.User = user;
            if (user == null)
            {
                return View("Login");
            }
            else { 
                var cars = _repo.GetAllCars();
                return View("Index", cars);
            }
        }
    }
}