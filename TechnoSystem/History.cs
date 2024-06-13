using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoSystem
{
    public partial class History : LayoutForm
    {
        string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

        DataTable dataTable = new DataTable();
        public History(string user, string pass)
        {
            adminShowValues(user, pass);
            InitializeComponent();
            LoadDataIntoDataGridView();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadDataIntoDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    string selectQuery = "SELECT * FROM TBL_HISTORY ORDER BY DATE_TIME DESC;";


                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {

                            adapter.Fill(dataTable);
                        }


                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        public void showAdmin(string user, string password)
        {
            adminShowValues(user, password);
        }

    }
}
