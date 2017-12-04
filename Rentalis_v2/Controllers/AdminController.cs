using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rentalis_v2.Models;

namespace Rentalis_v2.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cars()
        {
            var cars = _context.carModels.ToList();

            return View(cars);
        }

        public ActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCar(CarModels car)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCar", car);
            }

            if (car.Id == 0)
                _context.carModels.Add(car);
            else
            {
                var carInDb = _context.carModels.Single(c => c.Id == car.Id);
                carInDb.Name = car.Name;
                carInDb.Description = car.Description;
                carInDb.ProductionYear = car.ProductionYear;
            }

            _context.SaveChanges();

            return RedirectToAction("Cars");
        }

        public ActionResult CarDetails(int id)
        {
            var car = _context.carModels.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View(car);
        }

        public ActionResult EditCar(int id)
        {
            var car = _context.carModels.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View("AddCar",car);
        }

        public ActionResult DeleteCar(int id)
        {
            var car = _context.carModels.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View(car);
        }

        public ActionResult DeleteCarFromDb(CarModels car)
        {
            var carInDb = _context.carModels.Single(c => c.Id == car.Id);

            _context.carModels.Remove(carInDb);
            _context.SaveChanges();

            return RedirectToAction("Cars");
        }

        //[HttpPost, ActionName("DeleteCar")]
        //public ActionResult DeleteCar(int id)
        //{
        //    return RedirectToAction("Cars");
        //}
    }
}