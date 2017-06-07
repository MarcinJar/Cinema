using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Models
{
    public class Movie
    {
        public int DBKey { get; set; }

        public string Name { get; set; }

        public string Gener { get; set; }

        public int AcceptableAge { get; set; }

        public int DurationTime { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }
    }
}