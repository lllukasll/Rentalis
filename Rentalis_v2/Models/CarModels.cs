using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Rentalis_v2.Models
{
    public class CarModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Nazwa nie może być puste")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole Opis nie może być puste")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pole Rok Produkcji nie może być puste")]
        public string ProductionYear { get; set; }

        /*
        public int Doors { get; set; }
        public int Seets { get; set; }
        public int Abs { get; set; }
        public int PowerSteering { get; set; }
        public int GearBox { get; set; }
        public int Type { get; set; }
        public int FuelType { get; set; }
        public int AirConditioning { get; set; }
        public int CentralLocking { get; set; }
        public int AirBags { get; set; }
        */

    }
}