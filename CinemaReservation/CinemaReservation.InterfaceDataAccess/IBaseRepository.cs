using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.InterfaceDataAccess
{
    public interface IBaseRepository<T>
    {
        T Get(int movieDBKey);

        IEnumerable<T> GetAll();

        T Add(T movieToCreate);

        T Update(T movieToUpdate);

        bool Delete(int movieDBKey);
    }
}
