using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Model.Models
{
    public class Cinema
    {
        public int DBKey { get; set; }

        public string Name { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfReservedSeats { get; set; }
    }
}