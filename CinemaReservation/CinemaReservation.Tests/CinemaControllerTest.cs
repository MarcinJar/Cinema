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
        public void GetCinemaByDbkey_Test()
        {
            var controller = new CinemaController(cinemaList);

            var result = controller.GetCinema(cinemaList[0].DBKey);

            Assert.AreEqual<string>(result.Name, cinemaList[0].Name);
        }

        [TestMethod]
        public void GetListOfCinemas_Test()
        {
            var controller = new CinemaController(cinemaList);

            var result = controller.GetAllCinemaRooms();

            Assert.AreEqual<int>(result.Count(), cinemaList.Count());
        }

        [TestMethod]
        public void AddNewCinem_Test()
        {
            var controller = new CinemaController(cinemaList);

            Cinema cinema = new Cinema()
            {
                DBKey = 5,
                Name = "Fifth room",
                NumberOfReservedSeats = 0,
                NumberOfSeats = 20
            };

            var result = controller.AddCinema(cinema);

            Assert.AreEqual(result, cinemaList.Count());
        }

        [TestMethod]
        public void DeleteCinema_Test()
        {
            var controller = new CinemaController(cinemaList);

            var result = controller.DeleteCinema(1);

            Assert.AreEqual<int>(result, cinemaList.Count());
        }

        [TestMethod]
        public void UpdateCinema_Test()
        {
            var controller = new CinemaController(cinemaList);

            Cinema cinema = new Cinema() { Name = "Test Name", DBKey = 1};

            var result = controller.UpdateCinema(cinema);

            Assert.AreEqual<string>(result.Name, "Test Name");
        }

        private static IList<Cinema> cinemaList = new List<Cinema>
        {
            new Cinema() { DBKey = 1, Name = "First room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 2, Name = "Second room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 3, Name = "Third room", NumberOfReservedSeats = 0, NumberOfSeats = 15},
            new Cinema() { DBKey = 4, Name = "Fourth room", NumberOfReservedSeats = 0, NumberOfSeats = 15}
        };
    }
}
