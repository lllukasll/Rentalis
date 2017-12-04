using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

        [HttpPost, ValidateInput(false)]
        public ActionResult SaveCar(CarModels car)
        {
            if (!ModelState.IsValid)
            {
                return View("AddCar", car);
            }

            HttpPostedFileBase file = Request.Files["ImageData"];
            car.Image = ConvertToBytes(file);

            var NewCar = new CarModels
            {
                Id = car.Id,
                Name = car.Name,
                Description = car.Description,
                ShortDescription = car.ShortDescription,
                ProductionYear = car.ProductionYear,
                Image = car.Image,

                Abs = car.Abs,
                AirBags = car.AirBags,
                PowerSteering = car.PowerSteering,
                AirConditioning = car.AirConditioning,
                CentralLocking = car.CentralLocking,

                Doors = car.Doors,
                Seets = car.Seets,
                GearBox = car.GearBox,
                FuelType = car.FuelType,
                Type = car.Type
            };

            if (car.Id == null)
            {
                _context.carModels.Add(NewCar);
            }
            else
            {
                var carInDb = _context.carModels.Single(c => c.Id == car.Id);
                carInDb.Name = NewCar.Name;
                carInDb.Description = NewCar.Description;
                carInDb.ShortDescription = NewCar.ShortDescription;
                carInDb.ProductionYear = NewCar.ProductionYear;
                carInDb.Image = NewCar.Image;

                carInDb.Abs = NewCar.Abs;
                carInDb.AirBags = NewCar.AirBags;
                carInDb.PowerSteering = NewCar.PowerSteering;
                carInDb.AirConditioning = NewCar.AirConditioning;
                carInDb.CentralLocking = NewCar.CentralLocking;

                carInDb.Doors = NewCar.Doors;
                carInDb.Seets = NewCar.Seets;
                carInDb.GearBox = NewCar.GearBox;
                carInDb.FuelType = NewCar.FuelType;
                carInDb.Type = NewCar.Type;
            }

            _context.SaveChanges();

            return RedirectToAction("Cars");
        }

        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }

        public byte[] GetImageFromDataBase(int Id)
        {
            var q = from temp in _context.carModels where temp.Id == Id select temp.Image;
            byte[] cover = q.First();
            return cover;
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
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