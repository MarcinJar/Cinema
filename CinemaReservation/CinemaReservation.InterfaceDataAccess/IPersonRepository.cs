using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.InterfaceDataAccess
{
    public interface IPersonRepository
    {
        Person Get(int personDBKey);

        IEnumerable<Person> GetAll();

        Person Add(Person personToCreate);

        Person Update(Person personToUpdate);

        bool Delete(int personDBKey);
    }
}
