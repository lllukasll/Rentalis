using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rentalis_v2.Models;
using MySql.Data.MySqlClient;

namespace Rentalis_v2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DateTime dateFrom, DateTime dateTo)
        {
            string dT = dateTo.ToString("yyyyMMddhhmmss");
            string dF = dateFrom.ToString("yyyyMMddhhmmss");

            List<int> carIds = new List<int>();
            string query = String.Format(@"SELECT * FROM rentalisv2.carmodels C LEFT JOIN rentalisv2.bookingmodels B ON C.Id = B.carId WHERE B.carId IS null OR NOT ('{0}' >= dateTimeFrom && '{0}' <= dateTimeTo) AND NOT ('{1}' >= dateTimeFrom && '{1}' <= dateTimeTo);",dF,dT);

            MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=rentalisv2;UID=root;PASSWORD=;");
            try
            {
                using (MySqlCommand cmdDatabase = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmdDatabase.ExecuteReader();
                    while (reader.Read())
                    {
                        carIds.Add(Convert.ToInt16(reader["id"]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            var cars = _context.carModels.ToList();
            List<CarModels> result = cars.Where(c => carIds.Any(p2 => p2 == c.Id)).ToList();

            return View("List",result);
        }

        public ActionResult Cars()
        {
            var result = _context.carModels.ToList();

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}