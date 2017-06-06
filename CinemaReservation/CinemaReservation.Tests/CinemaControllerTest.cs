using CinemaReservation.Controllers;
using CinemaReservation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Tests
{
    [TestClass]
    public class CinemaControllerTest
    { 
        [TestMethod]
        public void GetCinemaByDbkey()
        {
            var controller = new CinemaController();

            var result = controller.GetCinema(1);

            Assert.AreEqual<string>(result.Name, "First room");
        }

        [TestMethod]
        public void GetListOfCinemas()
        {
            var controller = new CinemaController();

            var result = controller.GetAllCinemaRooms();

            Assert.AreEqual<int>(result.Count(), 4);
        }

        [TestMethod]
        public void AddNewCinem()
        {
            var controller = new CinemaController();

            Cinema cinema = new Cinema() {
                DBKey = 5, Name = "Fifth room", NumberOfReservedSeats = 0, NumberOfSeats = 20
            };

            var result = controller.AddCinema(cinema);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void DeleteCinema()
        {
            var controller = new CinemaController();

            var result = controller.DeleteCinema(1);

            Assert.AreEqual<int>(result, 3);
        }
    }
}
