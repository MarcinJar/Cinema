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
    public class FilmShowRepository : BaseRepository, IFilmShowRepository
    {
        public FilmShow Add(FilmShow toCreate)
        {
            FilmShow filmShow = null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    dbConn.Open();
                    using (SqlTransaction dbTran = dbConn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dyParams = new DynamicParameters();

                            dyParams.Add("@CinemaRoom", toCreate.CinemaRoom);
                            dyParams.Add("@DateOfFilmShow", toCreate.DateOfFilmShow);
                            dyParams.Add("@DBKeyCinemaRoom", toCreate.DBKeyCinemaRoom);
                            dyParams.Add("@DBKeyMovie", toCreate.DBKeyMovie);
                            dyParams.Add("@DisplayKind", toCreate.DisplayKind);
                            dyParams.Add("@DisplayMode", toCreate.DisplayMode);

                            filmShow = dbConn.Query<FilmShow>("dbo.filmshow_add", dyParams, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();

                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
                }

                return filmShow;
            }
            catch
            {
                return filmShow;
            }
        }

        public bool Delete(int DBKey)
        {
            int resut = 0;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                using (SqlTransaction dbTran = dbConn.BeginTransaction())
                {
                    try
                    {
                        resut = dbConn.Query<int>("dbo.filmshow_del", new { DBKey = DBKey }, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();

                        dbTran.Commit();
                    }
                    catch
                    {
                        dbTran.Rollback();
                    }
                }
            }

            return resut == 1;
        }

        public FilmShow Get(int DBKey)
        {
            FilmShow filmShow = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                filmShow = dbConn.Query<FilmShow>("dbo.filmshow_sel", new { DBKey = DBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return filmShow;
        }

        public IEnumerable<FilmShow> GetAll()
        {
            IEnumerable<FilmShow> filmShows = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                filmShows = dbConn.Query<FilmShow>("dbo.filmshow_all_sel", commandType: CommandType.StoredProcedure).ToList();
            }

            return filmShows;
        }

        public FilmShow Update(FilmShow toUpdate)
        {
            FilmShow filmShow = null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    dbConn.Open();
                    using (SqlTransaction dbTran = dbConn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dyParams = new DynamicParameters();

                            dyParams.Add("@DBKey", toUpdate.DBKey);
                            dyParams.Add("@CinemaRoom", toUpdate.CinemaRoom);
                            dyParams.Add("@DateOfFilmShow", toUpdate.DateOfFilmShow);
                            dyParams.Add("@DBKeyCinemaRoom", toUpdate.DBKeyCinemaRoom);
                            dyParams.Add("@DBKeyMovie", toUpdate.DBKeyMovie);
                            dyParams.Add("@DisplayKind", toUpdate.DisplayKind);
                            dyParams.Add("@DisplayMode", toUpdate.DisplayMode);

                            filmShow = dbConn.Query<FilmShow>("dbo.movie_upd", dyParams, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();

                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
                }

                return filmShow;
            }
            catch
            {
                return filmShow;
            }
        }
    }
}
