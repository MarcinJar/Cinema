using CinemaReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.Controllers
{
    public class CinemaController : ApiController
    {
        private static IList<Cinema> cinemaList = new List<Cinema>
        {
            new Cinema() { DBKey = 1, Name = "First room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 2, Name = "Second room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 3, Name = "Third room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 4, Name = "Fourth room", NumberOfReservedSeats = 0, NumberOfSeats = 15}
        };

        // GET: /api/Cinema/
        [HttpGet]
        public IEnumerable<Cinema> GetAllCinemaRooms()
        {
            return cinemaList;
        }

        // GET: /api/Cinema/id
        [HttpGet]
        public Cinema GetCinema(int id)
        {
            Cinema cinema = cinemaList.Where(x => x.DBKey == id).FirstOrDefault();
            return cinema;
        }

        // POST: /api/Cinema/
        [HttpPost]
        public int AddCinema(Cinema cinema)
        {
            cinemaList.Add(cinema);

            return cinemaList.Count;
        }

        // DELETE: /api/Cinema/id
        [HttpDelete]
        public int DeleteCinema(int id)
        {
            cinemaList.Remove(cinemaList.Where(c => c.DBKey == id).FirstOrDefault());

            return cinemaList.Count();
        }
    }
}
