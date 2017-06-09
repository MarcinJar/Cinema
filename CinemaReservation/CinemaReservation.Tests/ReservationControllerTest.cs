using CinemaReservation.WebApi.Controllers;
using CinemaReservation.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Tests
{
    [TestClass]
    public class ReservationControllerTest
    {
        [TestMethod]
        public void GetAllReservations_Test()
        {
            var controller = new ReservationController(listOfReservation);

            var result = controller.GetReservations();

            Assert.AreEqual<int>(result.Count(), listOfReservation.Count());
        }

        [TestMethod]
        public void GetReservationById_Test()
        {
            var controller = new ReservationController(listOfReservation);

            var result = controller.GetReservationById(listOfReservation[0].DBKey);

            Assert.AreEqual<string>(result.DateOfReservation, listOfReservation[0].DateOfReservation);
        }

        [TestMethod]
        public void UpdateReservation_Test()
        {
            var controller = new ReservationController(listOfReservation);

            Reservation reservation = new Reservation() { DateOfReservation = "2017-06-04", DBKey = 1 };

            var result = controller.UpdateReservation(reservation);

            Assert.AreEqual<string>(result.DateOfReservation, "2017-06-04");
        }

        [TestMethod]
        public void AddReservation_Test()
        {
            var controller = new ReservationController(listOfReservation);

            Reservation reservation = new Reservation() { DateOfReservation = "2017-06-04", DBKey = 1 };

            var result = controller.AddReservation(reservation);

            Assert.AreEqual<int>(result, listOfReservation.Count());
        }

        [TestMethod]
        public void DeleteReservation_Test()
        {
            var controller = new ReservationController(listOfReservation);

            var result = controller.DeleteReservation(listOfReservation[0].DBKey);

            Assert.AreEqual<int>(result, listOfReservation.Count());
        }

        private static IList<Reservation> listOfReservation = new List<Reservation>
        {
            new Reservation() { DBKey = 1, DateOfReservation = "2017-06-05", DBKeyFilmShow = 2, DBKeyPerson = 4},
            new Reservation() { DBKey = 2, DateOfReservation = "2017-06-07", DBKeyFilmShow = 1, DBKeyPerson = 2},
            new Reservation() { DBKey = 3, DateOfReservation = "2017-06-01", DBKeyFilmShow = 2, DBKeyPerson = 1}
        };
    }
}
