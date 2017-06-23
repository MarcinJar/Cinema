using CinemaReservation.InterfaceDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.Model.Models;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace CinemaReservation.DataAccess
{
    public class ReservationRepository : BaseRepository, IReservationRepository
    {
        public Reservation Add(Reservation toCreate)
        {
            Reservation reservation = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                DynamicParameters dbParams = new DynamicParameters();

                dbParams.Add("@@DateOfReservation", toCreate.DateOfReservation);
                dbParams.Add("@DBKeyFilmShow", toCreate.DBKeyFilmShow);
                dbParams.Add("@DBKeyPerson", toCreate.DBKeyPerson);

                dbConn.Open();
                reservation = dbConn.Query<Reservation>("dbo.reservation_add", dbParams, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return reservation;
        }

        public bool Delete(int DBKey)
        {
            int result = 0;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                result = dbConn.Query<int>("dbo.reservation_del", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return result == 1;
        }

        public Reservation Get(int DBKey)
        {
            Reservation reservation = null;

            using(SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                reservation = dbConn.Query<Reservation>("dbo.reservation_sel", commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return reservation;
        }

        public IEnumerable<Reservation> GetAll()
        {
            IEnumerable<Reservation> reservations = null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    dbConn.Open();
                    reservations = dbConn.Query<Reservation>("dbo.reservations_all_sel", commandType: CommandType.StoredProcedure).ToList();
                }

                return reservations;
            }
            catch
            {
                return reservations;
            }
        }

        public List<Seat> GetReservationSeats(int DBKeyReservation)
        {
            List<Seat> listOfReservationSeats = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                listOfReservationSeats = dbConn.Query<Seat>("dbo.reservation_seats_sel", commandType: CommandType.StoredProcedure).ToList();
            }

            return listOfReservationSeats;
        }

        public Reservation Update(Reservation toUpdate)
        {
            Reservation reservation = null;

            using(SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                DynamicParameters dbParams = new DynamicParameters();

                dbParams.Add("@@DBKey", toUpdate.DBKey);
                dbParams.Add("@@DateOfReservation", toUpdate.DateOfReservation);
                dbParams.Add("@DBKeyFilmShow", toUpdate.DBKeyFilmShow);
                dbParams.Add("@DBKeyPerson", toUpdate.DBKeyPerson);

                dbConn.Open();

                reservation = dbConn.Query<Reservation>("dbo.reservation_upd", dbParams, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return reservation;
        }
    }
}
