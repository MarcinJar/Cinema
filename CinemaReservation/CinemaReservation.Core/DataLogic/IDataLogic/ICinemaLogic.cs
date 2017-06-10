using CinemaReservation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservation.Core.DataLogic.IDataLogic
{
    public interface ICinemaLogic
    {
        Cinema Get(int cinemaDBKey);

        Cinema Add(Cinema cinamaToCreate);

        Cinema Update(Cinema cinemaToUpdate);

        bool Delete(int cinemaDBKey);
    }
}
