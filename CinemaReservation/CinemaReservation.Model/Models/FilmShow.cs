using CinemaReservation.Model.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Model.Models
{
    public class FilmShow
    {
        public int DBKey { get; set; }

        public string DateOfFilmShow { get; set; }

        public DisplayMode DisplayMode { get; set; }

        public DisplayKind DisplayKind { get; set; }

        public double PriceOfTicket { get; set; }

        public int DBKeyCinemaRoom { get; set; }

        public int DBKeyMovie { get; set; }
    }
}