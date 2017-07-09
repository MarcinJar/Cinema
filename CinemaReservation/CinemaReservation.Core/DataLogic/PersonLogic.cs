using CinemaReservation.Core.DataLogic.IDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;
using CinemaReservation.InterfaceDataAccess;
using log4net;

namespace CinemaReservation.Core.DataLogic
{
    public class PersonLogic : IPersonLogic
    {
        private IPersonRepository personRepository;
        private ILog log;

        public PersonLogic(IPersonRepository personRepository, ILog log)
        {
            this.personRepository = personRepository;
            this.log = log;
        }

        public Person Add(Person personToCreate)
        {
            return this.personRepository.Add(personToCreate);
        }

        public bool Delete(int personDBKey)
        {
            return this.personRepository.Delete(personDBKey);
        }

        public Person Get(int personDBKey)
        {
            return this.personRepository.Get(personDBKey);
        }

        public IEnumerable<Person> GetAll()
        {
            return this.personRepository.GetAll();
        }

        public Person Update(Person personToUpdate)
        {
            return this.personRepository.Update(personToUpdate);
        }
    }
}
