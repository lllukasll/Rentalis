using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rentalis_v2.Models
{
    public class CarModels
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Pole Nazwa nie może być puste")]
        public string Name { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Pole Opis nie może być puste")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Pole Opis nie może być puste")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Pole Rok Produkcji nie może być puste")]
        public string ProductionYear { get; set; }
        
        public byte[] Image { get; set; }
        
        public byte? Doors { get; set; }
        public byte? Seets { get; set; }
        public byte? FuelType { get; set; }
        public byte? Type { get; set; }
        public byte? GearBox { get; set; }
        
        public bool Abs { get; set; }
        public bool PowerSteering { get; set; }
        public bool AirConditioning { get; set; }
        public bool CentralLocking { get; set; }
        public bool AirBags { get; set; }
        
    }
}