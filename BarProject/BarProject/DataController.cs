using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace BarProject
{
    class DataController
    {

        string ConnectionString;

        public DataController()
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BarProjectDBConnectionString"].ConnectionString;
        }

        public bool konfirmoPerdorues(string Username, String Password)
        {
            string PasswordDatabase = string.Empty;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Password FROM Users where Email = '" + Username + "';", connection);
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        PasswordDatabase = reader.GetString(0);
                    }
                }

                reader.Close();

            }

            if (Password.Equals(PasswordDatabase))
            {
                return true;
            }
            else return false;

        }


        public UserModel returnUserID(string email)
        {
            UserModel userModel = new UserModel();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, Role FROM Users where Email = '" + email + "';", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                int UserID = 0;
                string Role = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserID = reader.GetInt32(0);
                        Role = reader.GetString(1);
                    }
                        
                }

                reader.Close();

                userModel.ID = UserID;
                userModel.Roli = Role;

            }

            return userModel;
        }


        public bool regjistroPerdorues (UserModel user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("Insert into Users (Name, Role, Email, Password) values ('" + user.Emri + "' , '" + user.Roli + "', '" + user.Email + "', '" + user.Password + "');", connection);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
        }



    }
}
