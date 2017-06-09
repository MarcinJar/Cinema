using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.WebApi.Controllers
{
    public class ReservationController : ApiController
    {
        private IList<Reservation> listOfReservations = new List<Reservation>();

        public ReservationController() { }

        public ReservationController(IList<Reservation> reservation)
        {
            this.listOfReservations = reservation;
        }

        // GET: /api/Reservation/
        [HttpGet]
        public IEnumerable<Reservation> GetReservations()
        {
            return listOfReservations;
        }

        // GET: /api/Reservation/id
        [HttpGet]
        public Reservation GetReservationById(int id)
        {
            return listOfReservations.Where(x => x.DBKey == id).FirstOrDefault();
        }

        // PUT: /api/Reservation/
        [HttpPut]
        public Reservation UpdateReservation(Reservation reservation)
        {
            Reservation res = listOfReservations.Where(x => x.DBKey == reservation.DBKey).FirstOrDefault();
            res.DateOfReservation = reservation.DateOfReservation;

            return res;
        }

        // POST: /api/Reservation/
        [HttpPost]
        public int AddReservation(Reservation person)
        {
            listOfReservations.Add(person);

            return listOfReservations.Count();
        }

        // DELETE: /api/Reservation/id
        [HttpDelete]
        public int DeleteReservation(int id)
        {
            listOfReservations.Remove(listOfReservations.Where(x => x.DBKey == id).FirstOrDefault());

            return listOfReservations.Count();
        }
    }
}
