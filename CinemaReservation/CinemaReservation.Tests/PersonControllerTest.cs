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
    public class PersonControllerTest
    {
        [TestMethod]
        public void GetAllMovies_Test()
        {
            var controller = new PersonController(listOfPerson);

            var result = controller.GetPerson();

            Assert.AreEqual<int>(result.Count(), listOfPerson.Count());
        }

        [TestMethod]
        public void GetMovieById_Test()
        {
            var controller = new PersonController(listOfPerson);

            var result = controller.GetPersonById(listOfPerson[0].DBKey);

            Assert.AreEqual<string>(result.Name, listOfPerson[0].Name);
        }

        [TestMethod]
        public void UpdateMovie_Test()
        {
            var controller = new PersonController(listOfPerson);

            Person person = new Person() { Name = "Test name", DBKey = 1 };

            var result = controller.UpdatePerson(person);

            Assert.AreEqual<string>(result.Name, "Test name");
        }

        [TestMethod]
        public void AddMovie_Test()
        {
            var controller = new PersonController(listOfPerson);

            Person person = new Person() { Name = "Test name" };

            var result = controller.AddPerson(person);

            Assert.AreEqual<int>(result, listOfPerson.Count());
        }

        [TestMethod]
        public void DeleteMovie_Test()
        {
            var controller = new PersonController(listOfPerson);

            var result = controller.DeletePerson(listOfPerson[0].DBKey);

            Assert.AreEqual<int>(result, listOfPerson.Count());
        }

        private static IList<Person> listOfPerson = new List<Person>
        {
            new Person() { DBKey = 1, DateOfBirth = "1992-06-21", Discount = 0, Login = "", Name = "Wojtek", Password = "", Surname = "Kowalski" },
            new Person() { DBKey = 2, DateOfBirth = "1987-01-09", Discount = 0, Login = "", Name = "Anna", Password = "", Surname = "Jelok" },
            new Person() { DBKey = 3, DateOfBirth = "1993-04-29", Discount = 0, Login = "", Name = "Grzegoż", Password = "", Surname = "Nakowski" }
        };
    }
}
