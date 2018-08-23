using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAppForNotes.Models;

namespace WebAppForNotes.DAL
{
    public class AppUserDAO : IAppUserDAO
    {
        private readonly string connectionString;
        private const string getUserWithUsernameSql = @"SELECT * FROM app_user WHERE username = @username;";
        private const string getUserWithUsernameAndPasswordSql = @"SELECT * FROM app_user WHERE username = @username AND password = @password;";

        public AppUserDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataAppUserModel GetUser(string username)
        {
            DataAppUserModel user = new DataAppUserModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(getUserWithUsernameSql, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user.Username = Convert.ToString(reader["username"]);
                        user.Password = Convert.ToString(reader["password"]);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return user;
        }

        public DataAppUserModel GetUser(string username, string password)
        {
            DataAppUserModel user = new DataAppUserModel();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(getUserWithUsernameAndPasswordSql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user.Username = Convert.ToString(reader["username"]);
                        user.Password = Convert.ToString(reader["password"]);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return user;
        }
    }
}