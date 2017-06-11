﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Model.Models
{
    public class Reservation
    {
        public List<Seat> Seats { get; set; }

        public Reservation()
        {
            this.Seats = new List<Seat>();
        }

        public int DBKey { get; set; }

        public int DBKeyPerson { get; set; }

        public string DateOfReservation { get; set; }

        public int DBKeyFilmShow { get; set; }

        public FilmShow FilmShow { get; set; }
    }
}