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
    public class CinemaLogic : ICinemaLogic
    {
        private ICinemaRepository cinemaRepository;
        private ILog log;

        public CinemaLogic(ICinemaRepository cinemaRepository, ILog log)
        {
            this.cinemaRepository = cinemaRepository;
            this.log = log;
        }

        public Cinema Add(Cinema cinamaToCreate)
        {
            return this.cinemaRepository.Add(cinamaToCreate);
        }

        public bool Delete(int cinemaDBKey)
        {
            return this.cinemaRepository.Delete(cinemaDBKey);
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
            IEnumerable<Cinema> cinemas = this.cinemaRepository.GetAll();

            if(cinemas != null)
            foreach(Cinema cinema in cinemas)
            {
                cinema.CinemaRooms = this.cinemaRepository.GetAllCinemaRooms(cinema.DBKey);
            }

            return cinemas;
        }

        public Cinema Update(Cinema cinemaToUpdate)
        {
            return this.cinemaRepository.Update(cinemaToUpdate);
        }
    }
}
