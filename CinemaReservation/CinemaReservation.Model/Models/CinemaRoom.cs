using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Model.Models
{
    public class CinemaRoom
    {
        public List<Seat> Seats { get; set; }

        public CinemaRoom()
        {
            this.Seats = new List<Seat>();
        }

        public int DBKey { get; set; }

        public int DBKeyCinema { get; set; }

        public string Name { get; set; }
    }
}
