using CinemaReservation.Controllers;
using CinemaReservation.Models;
using CinemaReservation.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Tests
{
    [TestClass]
    public class FilmShowControllerTest
    {
        [TestMethod]
        public void GetFilmShowByDbkey_Test()
        {
            var controller = new FilmShowController(filmMoviesList);

            var result = controller.GetFilmShow(filmMoviesList[0].DBKey);

            Assert.AreEqual<string>(result.DateOfFilmShow, filmMoviesList[0].DateOfFilmShow);
        }

        [TestMethod]
        public void GetListOfFilmShows_Test()
        {
            var controller = new FilmShowController(filmMoviesList);

            var result = controller.GetAllFilmShows();

            Assert.AreEqual<int>(result.Count(), filmMoviesList.Count());
        }

        [TestMethod]
        public void AddNewFilmShow_Test()
        {
            var controller = new FilmShowController(filmMoviesList);

            FilmShow filmShow = new FilmShow() { DBKey = 5, DateOfFilmShow = "2017-06-19", DisplayKind = DisplayKind._2D, DisplayMode = DisplayMode.Lector, PriceOfTicket = 19.00 };

            var result = controller.AddFilmShow(filmShow);

            Assert.AreEqual(result, filmMoviesList.Count());
        }

        [TestMethod]
        public void DeleteFilmShow_Test()
        {
            var controller = new FilmShowController(filmMoviesList);

            var result = controller.DeleteFilmShow(1);

            Assert.AreEqual<int>(result, filmMoviesList.Count());
        }

        [TestMethod]
        public void UpdateFilmShow_Test()
        {
            var controller = new FilmShowController(filmMoviesList);

            FilmShow filmShow = new FilmShow() { DBKey = 1, DateOfFilmShow = "2017-06-19", DisplayKind = DisplayKind._2D, DisplayMode = DisplayMode.Lector, PriceOfTicket = 19.00 };

            var result = controller.UpdateFilmShow(filmShow);

            Assert.AreEqual<string>(result.DateOfFilmShow, "2017-06-19");
        }

        private static IList<FilmShow> filmMoviesList = new List<FilmShow>
        {
            new FilmShow() { DBKey = 1, DateOfFilmShow = "2017-06-12", DisplayKind = DisplayKind._2D, DisplayMode = DisplayMode.Subtitles, PriceOfTicket = 15.00 },
            new FilmShow() { DBKey = 2, DateOfFilmShow = "2017-06-15", DisplayKind = DisplayKind._3D, DisplayMode = DisplayMode.Lector, PriceOfTicket = 19.00 },
            new FilmShow() { DBKey = 3, DateOfFilmShow = "2017-06-9", DisplayKind = DisplayKind._5D, DisplayMode = DisplayMode.Dubbing, PriceOfTicket = 25.00 },
            new FilmShow() { DBKey = 4, DateOfFilmShow = "2017-06-11", DisplayKind = DisplayKind._2D, DisplayMode = DisplayMode.Lector, PriceOfTicket = 19.00 }
        };
    }
}
