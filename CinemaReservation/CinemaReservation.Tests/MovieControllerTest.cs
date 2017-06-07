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
    public class MovieControllerTest
    {
        [TestMethod]
        public void GetAllMovies_Test()
        {
            var controller = new MovieController(listOfMovies);

            var result = controller.GetMovies();

            Assert.AreEqual<int>(result.Count(), listOfMovies.Count());
        }

        [TestMethod]
        public void GetMovieById_Test()
        {
            var controller = new MovieController(listOfMovies);

            var result = controller.GetMovieById(listOfMovies[0].DBKey);

            Assert.AreEqual<string>(result.Author, listOfMovies[0].Author);
        }

        [TestMethod]
        public void UpdateMovie_Test()
        {
            var controller = new MovieController(listOfMovies);

            Movie movie = new Movie() { Name = "Test name", DBKey = 1 };

            var result = controller.UpdateMovie(movie);

            Assert.AreEqual<string>(result.Name, "Test name");
        }

        [TestMethod]
        public void AddMovie_Test()
        {
            var controller = new MovieController(listOfMovies);

            Movie movie = new Movie() { Name = "Test name" };

            var result = controller.AddMovie(movie);

            Assert.AreEqual<int>(result, listOfMovies.Count());
        }

        [TestMethod]
        public void DeleteMovie_Test()
        {
            var controller = new MovieController(listOfMovies);

            var result = controller.DeleteMovie(listOfMovies[0].DBKey);

            Assert.AreEqual<int>(result, listOfMovies.Count());
        }

        private static IList<Movie> listOfMovies = new List<Movie>
        {
            new Movie() { AcceptableAge = 18, Author = "S. King", DBKey = 1,  DurationTime = 150, Gener = "Horror", Name = "Salem"},
            new Movie() { AcceptableAge = 12, Author = "J. Tern", DBKey = 2, DurationTime = 180, Gener = "Comedy", Name = "FmmP" },
            new Movie() { AcceptableAge = 6, Author = "Z. Nelon", DBKey = 3, DurationTime = 75, Gener = "Comedy", Name = "Przygody K." }
        };
    }
}
