using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechnoSystem
{
    public partial class LayoutForm : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
           );
        public LayoutForm()
        {
            InitializeComponent();

        }
         
        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDCard iDCard = new IDCard(Login.user, Login.pass);
            Hide();
            iDCard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard(Login.user, Login.pass);
   
            Hide();
            Dashboard.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History history = new History(Login.user, Login.pass);
            Hide();
            history.ShowDialog();
        }


        public void adminShowValues(string username, string password)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

                string displayQuery = "SELECT * FROM TBL_ADMIN WHERE ADMIN_USERNAME = @username AND PASSWORD = @password";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(displayQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label1.Text = reader["FULL_NAME"].ToString();

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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



    }
}
