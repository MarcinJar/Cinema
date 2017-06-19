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
    public class PersonController : ApiController
    {
        private IList<Person> listOfPersons = new List<Person>();
        private IPersonLogic personLogic;

        public PersonController() { }

        public PersonController(IPersonLogic personLogic)
        {
            this.personLogic = personLogic;
        }

        // GET: /api/Person/
        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            return this.personLogic.GetAll();
        }

        // GET: /api/Person/id
        [HttpGet]
        public Person GetPersonById(int id)
        {
            return this.personLogic.Get(id);
        }

        // PUT: /api/Person/
        [HttpPut]
        public Person UpdatePerson(Person person)
        {
            return this.personLogic.Update(person);
        }

        // POST: /api/Person/
        [HttpPost]
        public Person AddPerson(Person person)
        {
            return this.personLogic.Add(person);
        }

        // DELETE: /api/Person/id
        [HttpDelete]
        public bool DeletePerson(int id)
        {
            return this.personLogic.Delete(id);
        }
    }
}
