using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.WebApi.Controllers
{
    public class CinemaController : ApiController
    {
        private IList<Cinema> cinemaList = new List<Cinema>();

        public CinemaController() { }

        public CinemaController(IList<Cinema> cinemaList)
        {
            this.cinemaList = cinemaList;
        }

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

        // PUT: /api/Cinema/
        [HttpPut]
        public Cinema UpdateCinema(Cinema cinema)
        {
            Cinema cin = cinemaList.Where(x => x.DBKey == cinema.DBKey).FirstOrDefault();
            cin.Name = cinema.Name;

            return cin;
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
