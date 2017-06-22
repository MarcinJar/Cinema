using CinemaReservation.Core.DataLogic.IDataLogic;
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

        private IReservationLogic reservationLogic;

        public ReservationController() { }

        public ReservationController(IReservationLogic reservationLogic)
        {
            this.reservationLogic = reservationLogic;
        }

        // GET: /api/Reservation/
        [HttpGet]
        public IEnumerable<Reservation> GetReservations()
        {
            return this.reservationLogic.GetAll();
        }

        // GET: /api/Reservation/id
        [HttpGet]
        public Reservation GetReservationById(int id)
        {
            return this.reservationLogic.Get(id);
        }

        // PUT: /api/Reservation/
        [HttpPut]
        public Reservation UpdateReservation(Reservation reservation)
        {
            return this.reservationLogic.Update(reservation);
        }

        // POST: /api/Reservation/
        [HttpPost]
        public Reservation AddReservation(Reservation reservation)
        {
            return this.reservationLogic.Add(reservation);
        }

        // DELETE: /api/Reservation/id
        [HttpDelete]
        public bool DeleteReservation(int id)
        {
            return this.reservationLogic.Delete(id);
        }
    }
}
