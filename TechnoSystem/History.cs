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
        string connectionString = "Data Source=DESKTOP-MJEN1H5\\SQLEXPRESS;Initial Catalog=DB_KYAN;Persist Security Info=True;User ID=mm;Password=1;Encrypt=False;Trust Server Certificate=True";
        DataTable dataTable = new DataTable();
        public History()
        {
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

                    string selectQuery = "SELECT CARD_ID, TOPUP, DATE_TIME FROM TBL_HISTORY";


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
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
