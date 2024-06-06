using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechnoSystem
{
    internal class Loggin
    {
        public Loggin(string username, string password)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-MJEN1H5\\SQLEXPRESS;Initial Catalog=DB_KYAN;Persist Security Info=True;User ID=mm;Password=1;Encrypt=False;Trust Server Certificate=True";
                string selectQuery = "SELECT * FROM TBL_REGISTER WHERE USER_NAME = @username AND PASSWORD = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show($"Successfully Login {username}");
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password. Please try again.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");

            }
        }
    }
}
