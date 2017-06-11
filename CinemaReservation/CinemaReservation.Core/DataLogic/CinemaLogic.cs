using CinemaReservation.Core.DataLogic.IDataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;
using CinemaReservation.InterfaceDataAccess;

namespace CinemaReservation.Core.DataLogic
{
    public class CinemaLogic : ICinemaLogic
    {
        private ICinemaRepository cinemaRepository;

        public CinemaLogic(ICinemaRepository cinemaRepository)
        {
            this.cinemaRepository = cinemaRepository;
        }

        public Cinema Add(Cinema cinamaToCreate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int cinemaDBKey)
        {
            throw new NotImplementedException();
        }

        public Cinema Get(int cinemaDBKey)
        {
            if (cinemaDBKey <= 0)
                return null;

            Cinema cinema = this.cinemaRepository.Get(cinemaDBKey);

            if (cinema != null)
                cinema.CinemaRooms = this.cinemaRepository.GetAllCinemaRooms(cinemaDBKey);

            return cinema;
        }

        public IEnumerable<Cinema> GetAll()
        {
            return this.cinemaRepository.GetAll();
        }

        public Cinema Update(Cinema cinemaToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
