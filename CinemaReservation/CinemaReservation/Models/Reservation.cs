using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Models
{
    public class Reservation
    {
        public int DBKey { get; set; }

        public int DBKeyPerson { get; set; }

        public string DateOfReservation { get; set; }

        public int DBKeyFilmShow { get; set; }
    }
}