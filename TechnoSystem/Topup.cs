using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechnoSystem
{
    public partial class Topup : Form
    {
        string cardID;
        double topUP;
        DateTime dateTime;
        string category;
        public Topup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Topups()
        {
            cardID = cardIDtxt.Text;
            topUP = Convert.ToDouble(amounttxt.Text);
            dateTime = DateTime.Now;

            try
            {
                string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";


                string insertQuery = "INSERT INTO TBL_HISTORY (CARD_ID, TOPUP, DATE_TIME)" +
                   "VALUES (@cardID, @topUP, @dateTime )" +
                    "MERGE INTO TBL_SELLING AS Target " +
                    "USING (VALUES (@cardID, @topUP, @dateTime)) AS Source (CARD_ID, TOPUP, DATE_TIME) " +
                    "ON Target.CARD_ID = Source.CARD_ID " +
                    "WHEN MATCHED THEN " +
                    " UPDATE SET Target.AMOUNT = Target.AMOUNT + Source.TOPUP, Target.DATE_TIME = @dateTime " +
                    "WHEN NOT MATCHED THEN " +
                    "    INSERT (CARD_ID, TOPUP, AMOUNT, DATE_TIME) " +
                    "    VALUES (Source.CARD_ID, Source.TOPUP, Source.TOPUP, Source.DATE_TIME);";


                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@cardID", cardID);
                    command.Parameters.AddWithValue("@topUP", topUP);
                    command.Parameters.AddWithValue("@dateTime", dateTime);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Transaction is Succesfully");


                    string selectQuery = "SELECT CATEGORY FROM TBL_REGISTER WHERE CARD_ID = @cardID";
                    using (SqlCommand categoryCommand = new SqlCommand(selectQuery, connection))
                    {
                        categoryCommand.Parameters.AddWithValue("@cardID", cardID);
                        category = Convert.ToString(categoryCommand.ExecuteScalar());
                    }


                    printPreviewDialog1.Document = printDocument1;
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Suit Detail", 285, 200);
                    printPreviewDialog1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Topups();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString($"TravelEase Transport", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(35, 10));
            e.Graphics.DrawString($"Service", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(100, 40));
            e.Graphics.DrawString($"Category: {category}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(30, 80));

            e.Graphics.DrawString($"CardID: {cardID}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString($"Time: {dateTime}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 115));
            e.Graphics.DrawString($"Php {topUP}", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(100, 150));
        }
    }
}
