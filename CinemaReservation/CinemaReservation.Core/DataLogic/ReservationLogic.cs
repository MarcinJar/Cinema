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
    public class ReservationLogic : IReservationLogic
    {
        private IReservationRepository reservationRepository;

        public ReservationLogic(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
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
            return this.reservationRepository.Get(DBKey);
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
