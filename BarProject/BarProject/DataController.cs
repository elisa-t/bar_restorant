using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Windows.Forms;

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


        public bool shtoKategori(string emerKategori, string pershkrimKategori, PictureBox fotoKategori)
        {


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                fotoKategori.Image.Save(ms, fotoKategori.Image.RawFormat);

                 /*Array of Binary numbers that have been converted*/
                byte[] foto = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();


                try
                {
                    command.Parameters.AddWithValue("@emri", emerKategori);
                    command.Parameters.AddWithValue("@pershkrimi", pershkrimKategori);
                    command.Parameters.AddWithValue("@foto", foto);

                    command.CommandText = 
                        "Insert into Kategoria (EmriKategori, PershkrimKategori, FotoKategori) values (@emri, @pershkrimi, @foto)";

                    command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();

                    return true;

                }
                catch(Exception e)
                {
                    connection.Close();
                    return false;
                }

            }
        }


        public ArrayList ngarkoKategorite()
        {
            ArrayList kategoriList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID , EmriKategori, FotoKategori from Kategoria", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DataModel model = new DataModel();
                        model.ID = reader.GetInt32(0);
                        model.Emri = reader.GetString(1);
                        model.Foto = (byte[])reader[2];

                        kategoriList.Add(model);
                    }
                }

                reader.Close();
            }

            return kategoriList;
        }

        public bool fshiKategori(int kategoriID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand("Delete from Kategoria where ID = ' " + kategoriID + "'", connection);

                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch(Exception )
            {
                return false;
            }
        }


        public DataModel getKategori (int kategori)
        {
            DataModel model = new DataModel();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID , EmriKategori, PershkrimKategori, FotoKategori from Kategoria", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        model.ID = reader.GetInt32(0);
                        model.Emri = reader.GetString(1);
                        model.Pershkrimi = reader.GetString(2);
                        model.Foto = (byte[])reader[3];
                    }
                }
                reader.Close();
            }
            return model;
        }

        public bool editKategori(DataModel kategoriModel)
        {
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                /*Start a local transaction*/
                SqlTransaction sqlTran = connection.BeginTransaction();

                /*Enlist a command in the current transaction*/
                SqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;

                try
                {
                    command.Parameters.AddWithValue("@KategoriID", kategoriModel.ID);
                    command.Parameters.AddWithValue("@Emri", kategoriModel.Emri);
                    command.Parameters.AddWithValue("@Pershkrimi", kategoriModel.Pershkrimi);
                    command.Parameters.AddWithValue("@Foto", kategoriModel.Foto);

                    command.CommandText =
                        "Update Kategoria set Emri = @Emri, Pershkrimi = @Pershkrimi, Foto = @Foto where ID = @KategoriID";

                    command.ExecuteNonQuery();

                    sqlTran.Commit();

                    connection.Close();

                    return true;

                }
                catch(Exception)
                {
                    connection.Close();
                    return false;
                }

            }

        }



    }
}
