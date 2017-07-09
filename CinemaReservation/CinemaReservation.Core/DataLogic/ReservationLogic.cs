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
    public class ReservationLogic : IReservationLogic
    {
        private IReservationRepository reservationRepository;
        private ILog log;

        public ReservationLogic(IReservationRepository reservationRepository, ILog log)
        {
            this.reservationRepository = reservationRepository;
            this.log = log;
        }

        public Reservation Add(Reservation toCreate)
        {
            return this.reservationRepository.Add(toCreate);
        }

        public bool Delete(int DBKey)
        {
            return this.reservationRepository.Delete(DBKey);
        }

        public Reservation Get(int DBKey)
        {
            Reservation reservation = this.reservationRepository.Get(DBKey);

            reservation.Seats = this.reservationRepository.GetReservationSeats(DBKey);

            return reservation;
        }

        public IEnumerable<Reservation> GetAll()
        {
            return this.reservationRepository.GetAll();
        }

        public Reservation Update(Reservation toUpdate)
        {
            return this.reservationRepository.Update(toUpdate);
        }
    }
}
