using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaReservation.InterfaceDataAccess;
using CinemaReservation.Model.Models;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace CinemaReservation.DataAccess
{
    public class CinemaRepository : BaseRepository, ICinemaRepository
    {
        public Cinema Add(Cinema cinamaToCreate)
        {
            Cinema cinema = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                DynamicParameters dyParams = new DynamicParameters();

                dyParams.Add("@Name", cinamaToCreate.Name);
                dyParams.Add("@PostCode", cinamaToCreate.PostCode);
                dyParams.Add("@Street", cinamaToCreate.Street);
                dyParams.Add("@BuildNumber", cinamaToCreate.BuildNumber);
                dyParams.Add("@CinemaRooms", cinamaToCreate.CinemaRooms);
                dyParams.Add("@City", cinamaToCreate.City);
                dyParams.Add("@Apartments", cinamaToCreate.Apartments);

                dbConn.Open();
                dbConn.Query("dbo.cinema_add", dyParams, commandType: CommandType.StoredProcedure);
            }

            return cinema;
        }

        public bool Delete(int cinemaDBKey)
        {
            throw new NotImplementedException();
        }

        public Cinema Get(int cinemaDBKey)
        {
            Cinema cinema = null;

            using(SqlConnection dbConn = new SqlConnection(this.connection.ConnectionString))
            {
                dbConn.Open();
                cinema = dbConn.Query<Cinema>("dbo.cinema_sel", new { DBKey = cinemaDBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return cinema;
        }

        public IEnumerable<Cinema> GetAll()
        {
            IEnumerable<Cinema> cinemas = null;

            using(SqlConnection dbConn = new SqlConnection(this.connection.ConnectionString))
            {
                dbConn.Open();
                cinemas = dbConn.Query<Cinema>("dbo.cinema_all_sel", commandType: CommandType.StoredProcedure).ToList();
            }

            return cinemas;
        }

        public List<CinemaRoom> GetAllCinemaRooms(int cinemaDBKey)
        {
            List<CinemaRoom> cinemaRooms = null;

            using (SqlConnection dbConn = new SqlConnection(this.connection.ConnectionString))
            {
                dbConn.Open();
                cinemaRooms = (List<CinemaRoom>)dbConn.Query<CinemaRoom>("dbo.cinema_rooms_all_sel", new { DBKeyCinema = cinemaDBKey }, commandType: CommandType.StoredProcedure);
            }

            return cinemaRooms;
        }

        public Cinema Update(Cinema cinemaToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
