using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaReservation.Model.Models
{
    public class Cinema
    {
        public List<CinemaRoom> CinemaRooms { get; set; }

        public Cinema()
        {
            this.CinemaRooms = new List<CinemaRoom>();
        }

        public int DBKey { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int BuildNumber { get; set; }

        public string Apartments { get; set; }

        public int PostCode { get; set; }
    }
}