using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TechnoSystem
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        public void showValues(int cardid, string username, string password)
        {
            try
            {

                string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

                string displayQuery = @"

                    SELECT CARD_ID, FIRST_NAME, LAST_NAME, USER_NAME, EMAIL, ADDRESS, MOBIBLE_NO, GENDER, REGISTER_DATE, PICTURE, CATEGORY 
                    FROM TBL_REGISTER 
                    WHERE USER_NAME = @username AND PASSWORD = @password;
                    SELECT AMOUNT FROM TBL_SELLING WHERE CARD_ID = @cardid;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(displayQuery, connection))
                    {
                        command.Parameters.AddWithValue("@cardid", cardid);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCardID.Text = reader["CARD_ID"].ToString();
                                txtFirstName.Text = reader["FIRST_NAME"].ToString();
                                txtLastName.Text = reader["LAST_NAME"].ToString();
                                txtEmail.Text = reader["EMAIL"].ToString();
                                txtUsername.Text = reader["USER_NAME"].ToString();
                                txtAddress.Text = reader["ADDRESS"].ToString();
                                txtMobileNumber.Text = reader["MOBIBLE_NO"].ToString();
                                txtGender.Text = reader["GENDER"].ToString();
                                txtRegisterDate.Text = reader["REGISTER_DATE"].ToString();
                                txtCategory.Text = reader["CATEGORY"].ToString();

                                if (reader["PICTURE"] != DBNull.Value)
                                {
                                    byte[] pictureData = (byte[])reader["PICTURE"];
                                    if (pictureData.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(pictureData))
                                        {
                                            picBoxCircle1.Image = Image.FromStream(ms);
                                        }
                                    }
                                }
                            }
                            if (reader.NextResult() && reader.Read())
                            {
                                txtTravelCash.Text = reader["AMOUNT"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No user found with the provided username and password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }
    }
}
