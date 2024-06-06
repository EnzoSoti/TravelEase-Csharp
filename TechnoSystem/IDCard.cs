using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechnoSystem
{
    public partial class IDCard : LayoutForm
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
        DataTable dataTable = new DataTable();
        string connectionString = "Data Source=DESKTOP-MJEN1H5\\SQLEXPRESS;Initial Catalog=DB_KYAN;Persist Security Info=True;User ID=mm;Password=1;Encrypt=False;Trust Server Certificate=True";



        public IDCard()
        {
            InitializeComponent();
            searchTxt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, searchTxt.Width, searchTxt.Height, 30, 30));

            ArrayList categories = new ArrayList();
            categories.Add("Student");
            categories.Add("Citizens");
            categories.Add("PWD");
            categories.Add("Senior");

            foreach (string category in categories)
            {
                categoryCMB.Items.Add(category);
            }
        }

        public void LoadDataIntoDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    string selectQuery = "SELECT * FROM TBL_REGISTER";


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

        public void filter()
        {
            try
            {
                // Get the selected item from the ComboBox
                string selectedValue = categoryCMB.SelectedItem.ToString();

                // Clear the existing data in the DataTable
                dataTable.Clear();

                // Create a SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM TBL_REGISTER WHERE CATEGORY = @data";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@data", selectedValue);
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

        public void Search()
        {
            try
            {
                string search = searchTxt.Text;

                using (SqlConnection MyDBConnectionString = new SqlConnection(connectionString))
                {
                    if (MyDBConnectionString.State == ConnectionState.Closed)
                        MyDBConnectionString.Open();
                    using (DataTable dt = new DataTable("Card"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT  * FROM TBL_REGISTER WHERE CARD_ID=@cardid", MyDBConnectionString))
                        {
                            cmd.Parameters.AddWithValue("cardid", search);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void refreshReg()
        {

            {
                string sqlstm = " SELECT * FROM TBL_REGISTER";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, connectionString);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "TBL_REGISTER");
                dataGridView1.DataSource = DS.Tables[0];
            }

        }



        private void IDCard_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Additem additem = new Additem();
            additem.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Topup topup = new Topup();
            topup.ShowDialog();
        }

        private void categoryCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Additem additem = new Additem();
            additem.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string cardID = dataGridView1.CurrentRow.Cells["CARD_ID"].Value.ToString();
                Additem addnew = new Additem();
                addnew.Delete(cardID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
