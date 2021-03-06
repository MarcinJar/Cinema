﻿using CinemaReservation.InterfaceDataAccess;
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
                    dbConn.Open();
                    using (SqlTransaction dbTran = dbConn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dyParams = new DynamicParameters();

                            dyParams.Add("@AcceptableAge", movieToCreate.AcceptableAge);
                            dyParams.Add("@Author", movieToCreate.Author);
                            dyParams.Add("@Description", movieToCreate.Description);
                            dyParams.Add("@DurationTime", movieToCreate.DurationTime);
                            dyParams.Add("@Gener", movieToCreate.Gener);
                            dyParams.Add("@Name", movieToCreate.Name);

                            movie = dbConn.Query<Movie>("dbo.movie_add", dyParams, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();

                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
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
                using (SqlTransaction dbTran = dbConn.BeginTransaction())
                {
                    try
                    {
                        resut = dbConn.Query<int>("dbo.movie_del", new { DBKey = movieDBKey }, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();

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
                    dbConn.Open();
                    using (SqlTransaction dbTran = dbConn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dyParams = new DynamicParameters();

                            dyParams.Add("@DBKey", movieToUpdate.DBKey);
                            dyParams.Add("@AcceptableAge", movieToUpdate.AcceptableAge);
                            dyParams.Add("@Author", movieToUpdate.Author);
                            dyParams.Add("@Description", movieToUpdate.Description);
                            dyParams.Add("@DurationTime", movieToUpdate.DurationTime);
                            dyParams.Add("@Gener", movieToUpdate.Gener);
                            dyParams.Add("@Name", movieToUpdate.Name);

                            movie = dbConn.Query<Movie>("dbo.movie_upd", dyParams, commandType: CommandType.StoredProcedure).FirstOrDefault();

                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
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
