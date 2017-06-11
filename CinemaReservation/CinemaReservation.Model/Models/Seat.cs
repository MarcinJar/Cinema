using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Model.Models
{
    public class Seat
    {
        public int DBKey { get; set; }

        public int RowNumber { get; set; }

        public int SeatNumber { get; set; }

        public int DBKeyCinemaRoom { get; set; }

        public bool Reserved { get; set; }
    }
}
