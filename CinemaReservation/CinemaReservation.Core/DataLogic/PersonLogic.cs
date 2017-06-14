using CinemaReservation.Core.DataLogic.IDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;

namespace CinemaReservation.Core.DataLogic
{
    public class PersonLogic : IPersonLogic
    {
        public Person Add(Person personToCreate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int personDBKey)
        {
            throw new NotImplementedException();
        }

        public Person Get(int personDBKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person personToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
