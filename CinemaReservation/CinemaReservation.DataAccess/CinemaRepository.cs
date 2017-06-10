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
            throw new NotImplementedException();
        }

        public bool Delete(int cinemaDBKey)
        {
            throw new NotImplementedException();
        }

        public Cinema Get(int cinemaDBKey)
        {
            Cinema cinema = null;

            using (SqlConnection dbConn = new SqlConnection(this.connection.ConnectionString))
            {
                dbConn.Open();
                cinema = dbConn.Query<Cinema>("dbo.cinema_sel", new { DBKey = cinemaDBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return cinema;
        }

        public Cinema Update(Cinema cinemaToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
