using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.InterfaceDataAccess
{
    public interface ICinemaRepository
    {
        Cinema Get(int cinemaDBKey);

        Cinema Add(Cinema cinamaToCreate);

        Cinema Update(Cinema cinemaToUpdate);

        bool Delete(int cinemaDBKey);
    }
}
