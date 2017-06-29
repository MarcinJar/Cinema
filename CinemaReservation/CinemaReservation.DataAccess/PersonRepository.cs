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
    public class PersonRepository : BaseRepository ,IPersonRepository
    {
        public Person Add(Person personToCreate)
        {
            Person person = null;
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

                            dyParams.Add("@DateOfBirth", personToCreate.DateOfBirth);
                            dyParams.Add("@Discount", personToCreate.Discount);
                            dyParams.Add("@Login", personToCreate.Login);
                            dyParams.Add("@Name", personToCreate.Name);
                            dyParams.Add("@Password", personToCreate.Password);
                            dyParams.Add("@Surname", personToCreate.Surname);

                            person = dbConn.Query<Person>("odb.person_add", dyParams, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();
                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
                }

                return person;
            }
            catch
            {
                return person;
            }
        }

        public bool Delete(int personDBKey)
        {
            int result = 0;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                using (SqlTransaction dbTran = dbConn.BeginTransaction())
                {
                    try
                    {
                        result = dbConn.Query<int>("dbo.person_del", new { DBKey = personDBKey }, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();
                        dbTran.Commit();
                    }
                    catch
                    {
                        dbTran.Rollback();
                    }
                }
            }

            return result == 1; 
        }

        public Person Get(int personDBKey)
        {
            Person person = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                person = dbConn.Query<Person>("dbo.person_sel", new { DBKey = personDBKey }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            IEnumerable<Person> persons = null;

            using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
            {
                dbConn.Open();
                persons = dbConn.Query<Person>("dbo.persons_all_sel", commandType: CommandType.StoredProcedure).ToList();
            }

            return persons;
        }

        public Person Update(Person personToUpdate)
        {
            Person person = null;

            try
            {
                using (SqlConnection dbConn = new SqlConnection(connection.ConnectionString))
                {
                    using (SqlTransaction dbTran = dbConn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dyParams = new DynamicParameters();

                            dyParams.Add("@DateOfBirth", personToUpdate.DateOfBirth);
                            dyParams.Add("@DBKey", personToUpdate.DBKey);
                            dyParams.Add("@Discount", personToUpdate.Discount);
                            dyParams.Add("@Login", personToUpdate.Login);
                            dyParams.Add("@Name", personToUpdate.Name);
                            dyParams.Add("@Password", personToUpdate.Password);
                            dyParams.Add("@Surname", personToUpdate.Surname);

                            dbConn.Open();
                            person = dbConn.Query<Person>("dbo.person_upd", dyParams, commandType: CommandType.StoredProcedure, transaction: dbTran).FirstOrDefault();
                            dbTran.Commit();
                        }
                        catch
                        {
                            dbTran.Rollback();
                        }
                    }
                }

                return person;
            }
            catch
            {
                return person;
            }
        }
    }
}
