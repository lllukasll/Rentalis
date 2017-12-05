using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalis_v2.Models
{
    public class BookingModels
    {
        public int? Id { get; set; }

        public int carId { get; set; }

        public int userId { get; set; }

        public DateTime DateTimeFrom { get; set; }

        public DateTime DateTimeTo { get; set; }
    }
}