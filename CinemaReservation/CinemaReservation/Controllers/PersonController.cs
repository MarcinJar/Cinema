using CinemaReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CinemaReservation.Controllers
{
    public class PersonController : ApiController
    {
        private IList<Person> listOfPersons = new List<Person>();

        public PersonController() { }

        public PersonController(IList<Person> person)
        {
            this.listOfPersons = person;
        }

        // GET: /api/Person/
        [HttpGet]
        public IEnumerable<Person> GetPerson()
        {
            return listOfPersons;
        }

        // GET: /api/Person/id
        [HttpGet]
        public Person GetPersonById(int id)
        {
            return listOfPersons.Where(x => x.DBKey == id).FirstOrDefault();
        }

        // PUT: /api/Person/
        [HttpPut]
        public Person UpdatePerson(Person person)
        {
            Person per = listOfPersons.Where(x => x.DBKey == person.DBKey).FirstOrDefault();
            per.Name = person.Name;

            return per;
        }

        // POST: /api/Person/
        [HttpPost]
        public int AddPerson(Person person)
        {
            listOfPersons.Add(person);

            return listOfPersons.Count();
        }

        // DELETE: /api/Person/id
        [HttpDelete]
        public int DeletePerson(int id)
        {
            listOfPersons.Remove(listOfPersons.Where(x => x.DBKey == id).FirstOrDefault());

            return listOfPersons.Count();
        }
    }
}
