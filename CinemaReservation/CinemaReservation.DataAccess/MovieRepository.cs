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
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        public Movie Add(Movie movieToCreate)
        {
            Movie movie = null;  

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    DynamicParameters dyParams = new DynamicParameters();

                    dyParams.Add("@AcceptableAge", movieToCreate.AcceptableAge);
                    dyParams.Add("@AcceptableAge", movieToCreate.Author);
                    dyParams.Add("@AcceptableAge", movieToCreate.Description);
                    dyParams.Add("@AcceptableAge", movieToCreate.DurationTime);
                    dyParams.Add("@AcceptableAge", movieToCreate.Gener);
                    dyParams.Add("@AcceptableAge", movieToCreate.Name);

                    dbConn.Open();
                    movie = dbConn.Query<Movie>("dbo.movie_add", dyParams, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }

                return movie;
            }
            catch
            {
                return movie;
            }
        }

        public bool Delete(int movieDBKey)
        {
            int resut = 0;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                resut = dbConn.Query<int>("dbo.movie_del", new { DBKey = movieDBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return resut == 1;
        }

        public Movie Get(int movieDBKey)
        {
            Movie movie = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                movie = dbConn.Query<Movie>("dbo.movie_sel", new { DBKey = movieDBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return movie;
        }

        public IEnumerable<Movie> GetAll()
        {
            IEnumerable<Movie> movies = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                movies = dbConn.Query<Movie>("dbo.movies_all_sel", commandType: CommandType.StoredProcedure).ToList();
            }

            return movies;
        }

        public Movie Update(Movie movieToUpdate)
        {
            Movie movie = null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    DynamicParameters dyParams = new DynamicParameters();

                    dyParams.Add("@DBKey", movieToUpdate.DBKey);
                    dyParams.Add("@AcceptableAge", movieToUpdate.AcceptableAge);
                    dyParams.Add("@AcceptableAge", movieToUpdate.Author);
                    dyParams.Add("@AcceptableAge", movieToUpdate.Description);
                    dyParams.Add("@AcceptableAge", movieToUpdate.DurationTime);
                    dyParams.Add("@AcceptableAge", movieToUpdate.Gener);
                    dyParams.Add("@AcceptableAge", movieToUpdate.Name);

                    dbConn.Open();
                    movie = dbConn.Query<Movie>("dbo.movie_upd", dyParams, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }

                return movie;
            }
            catch
            {
                return movie;
            }
        }
    }
}
