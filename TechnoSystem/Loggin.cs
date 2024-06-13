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
        public Loggin(int cardid, string username, string password)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

                string selectQuery = "SELECT * FROM TBL_REGISTER WHERE  CARD_ID  = @cardid AND USER_NAME = @username AND PASSWORD = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@cardid", cardid);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show($"Successfully Login {username}");

                                User user = new User();
                                user.showValues(cardid, username, password);
                                user.ShowDialog();

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
