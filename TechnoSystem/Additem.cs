using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TechnoSystem
{
    public partial class Additem : Form
    {

        string EmailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        string MobnumPattern = "^09\\d{9}$";
        string PassPattern = "^[A-Z].{7,}$";
        string DatePattern = @"^\d{2}/\d{2}/\d{2}$";
        string fname;
        string lname;
        string username;
        string email;
        string address;
        string mobileNum;
        string password;
        string gender;
        string date;
        Image picture;
        string category;

        public Additem()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ArrayList gender = new ArrayList();
            gender.Add("Male");
            gender.Add("Female");

            foreach (string g in gender)
            {
                genderCMB.Items.Add(g);
            }

            ArrayList categories = new ArrayList();
            categories.Add("Student");
            categories.Add("Citizens");
            categories.Add("PWD");
            categories.Add("Senior");

            foreach (string category in categories)
            {
                categoriesCMB.Items.Add(category);
            }

            categoriesCMB.Text = "Categories";
            categoriesCMB.ForeColor = System.Drawing.Color.Gray;
        }
        string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Image";
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picBoxCircle1.ImageLocation = openFileDialog.FileName;
            }
        }

        public void Add()
        {
            try
            {
                fname = FnameTextBox.Text.Trim();
                lname = LnametextBox.Text.Trim();
                username = UnametextBox.Text.Trim();
                email = EmailtextBox.Text.Trim();
                address = AddresstextBox.Text.Trim();
                mobileNum = MobnumtextBox.Text.Trim();
                password = PasswordtextBox.Text;
                gender = genderCMB.Text.Trim();
                date = DatetextBox.Text.Trim();
                picture = pictureBox1.Image;
                category = categoriesCMB.Text.Trim();


                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                   string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                   string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(mobileNum) ||
                   string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender) ||
                   picture == null || string.IsNullOrWhiteSpace(date))
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    if (!Regex.IsMatch(email, EmailPattern))
                    {
                        MessageBox.Show("Invalid email format.");
                    }
                    else
                    {
                        if (!Regex.IsMatch(mobileNum, MobnumPattern))
                        {
                            MessageBox.Show("Invalid mobile number format.");
                        }
                        else
                        {
                            if (!Regex.IsMatch(password, PassPattern))
                            {
                                MessageBox.Show("Password should start with a capital letter and have at least 8 characters.");
                            }
                            else
                            {
                                if (!gender.Equals("Male") && !gender.Equals("Female"))
                                {
                                    MessageBox.Show("Invalid gender.");
                                }
                                else
                                {
                                    if (!Regex.IsMatch(date, DatePattern))
                                    {
                                        MessageBox.Show("Invalid date format. Please use dd/mm/yy.");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";


                                            byte[] imageData = null;
                                            if (pictureBox1.Image != null)
                                            {
                                                using (MemoryStream ms = new MemoryStream())
                                                {
                                                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                                                    imageData = ms.ToArray();
                                                }
                                            }


                                            string insertQuery = "INSERT INTO TBL_REGISTER (FIRST_NAME, LAST_NAME, USER_NAME, EMAIL, ADDRESS, MOBIBLE_NO, PASSWORD, GENDER, REGISTER_DATE, PICTURE, CATEGORY ) " +
                                                "VALUES (@fname, @lname, @username, @email, @address, @mobileNum, @password, @gender, @date, @picture, @category)";

                                            using (SqlConnection connection = new SqlConnection(connectionString))
                                            using (SqlCommand command = new SqlCommand(insertQuery, connection))
                                            {
                                                command.Parameters.AddWithValue("@fname", fname);
                                                command.Parameters.AddWithValue("@lname", lname);
                                                command.Parameters.AddWithValue("@username", username);
                                                command.Parameters.AddWithValue("@email", email);
                                                command.Parameters.AddWithValue("@address", address);
                                                command.Parameters.AddWithValue("@mobileNum", mobileNum);
                                                command.Parameters.AddWithValue("@password", password);
                                                command.Parameters.AddWithValue("@gender", gender);
                                                command.Parameters.AddWithValue("@date", date);
                                                command.Parameters.AddWithValue("@picture", imageData);
                                                command.Parameters.AddWithValue("@category", category);

                                                connection.Open();
                                                int rowsAffected = command.ExecuteNonQuery();
                                                MessageBox.Show(rowsAffected + " row(s) inserted successfully!");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error: " + ex.Message);
                                        }
                                        try
                                        {

                                            IDCard generateId = (IDCard)Application.OpenForms["IDCard"];
                                            if (generateId != null)
                                            {
                                                generateId.refreshReg();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error: Unable to find the parent form.");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error: " + ex.Message);
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Update()
        {
            try
            {
                string cardID = cardIDTextBox.Text;
                fname = FnameTextBox.Text.Trim();
                lname = LnametextBox.Text.Trim();
                username = UnametextBox.Text.Trim();
                email = EmailtextBox.Text.Trim();
                address = AddresstextBox.Text.Trim();
                mobileNum = MobnumtextBox.Text.Trim();
                password = PasswordtextBox.Text;
                gender = genderCMB.Text.Trim();
                date = DatetextBox.Text.Trim();
                picture = pictureBox1.Image;
                category = categoriesCMB.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) ||
                   string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                   string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(mobileNum) ||
                   string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender) ||
                   picture == null || string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(cardID))
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    if (!Regex.IsMatch(email, EmailPattern))
                    {
                        MessageBox.Show("Invalid email format.");
                    }
                    else
                    {
                        if (!Regex.IsMatch(mobileNum, MobnumPattern))
                        {
                            MessageBox.Show("Invalid mobile number format.");
                        }
                        else
                        {
                            if (!Regex.IsMatch(password, PassPattern))
                            {
                                MessageBox.Show("Password should start with a capital letter and have at least 8 characters.");
                            }
                            else
                            {
                                if (!gender.Equals("Male") && !gender.Equals("Female"))
                                {
                                    MessageBox.Show("Invalid gender.");
                                }
                                else
                                {
                                    if (!Regex.IsMatch(date, DatePattern))
                                    {
                                        MessageBox.Show("Invalid date format. Please use dd/mm/yy.");
                                    }
                                    else
                                    {
                                        string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";


                                        string updateQuery = "UPDATE TBL_REGISTER SET FIRST_NAME = @fname, LAST_NAME = @lname, USER_NAME = @username, " +
                                                             "EMAIL = @email, ADDRESS = @address, MOBIBLE_NO  = @mobileNum, PASSWORD = @password, " +
                                                             "GENDER = @gender, REGISTER_DATE = @date, PICTURE = @picture, CATEGORY = @category " +
                                                             "WHERE CARD_ID = @cardID";

                                        using (SqlConnection connection = new SqlConnection(connectionString))
                                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                                        {
                                            byte[] imageData = null;
                                            if (pictureBox1.Image != null)
                                            {
                                                using (MemoryStream ms = new MemoryStream())
                                                {
                                                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                                                    imageData = ms.ToArray();
                                                }
                                            }

                                            command.Parameters.AddWithValue("@cardID", cardID);
                                            command.Parameters.AddWithValue("@fname", fname);
                                            command.Parameters.AddWithValue("@lname", lname);
                                            command.Parameters.AddWithValue("@username", username);
                                            command.Parameters.AddWithValue("@email", email);
                                            command.Parameters.AddWithValue("@address", address);
                                            command.Parameters.AddWithValue("@mobileNum", mobileNum);
                                            command.Parameters.AddWithValue("@password", password);
                                            command.Parameters.AddWithValue("@gender", gender);
                                            command.Parameters.AddWithValue("@date", date);
                                            command.Parameters.AddWithValue("@picture", imageData);
                                            command.Parameters.AddWithValue("@category", category);

                                            connection.Open();
                                            int rowsAffected = command.ExecuteNonQuery();
                                            if (rowsAffected > 0)
                                            {
                                                MessageBox.Show("Data has been updated");
                                            }
                                            else
                                            {
                                                MessageBox.Show("No record updated. Please check the Card ID.");
                                            }
                                        }

                                        try
                                        {
                                            IDCard generateId = (IDCard)Application.OpenForms["IDCard"];
                                            if (generateId != null)
                                            {
                                                generateId.refreshReg();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error: Unable to find the parent form.");
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error: " + ex.Message);
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Delete(string cardID)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(cardID))
                    {
                        MessageBox.Show("Please provide a Card ID.");
                    }
                    else
                    {
                        string connectionString = "Data Source=DESKTOP-HU962IE;Initial Catalog=TravelEaseDB;Persist Security Info=True;User ID=root1;Password=password1;Encrypt=False;TrustServerCertificate=True";


                        string deleteQuery = "DELETE FROM TBL_REGISTER WHERE CARD_ID = @cardID";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@cardID", cardID);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No record found with the provided Card ID.");
                            }
                        }

                        try
                        {
                            IDCard generateId = (IDCard)Application.OpenForms["IDCard"];
                            if (generateId != null)
                            {
                                generateId.refreshReg();
                            }
                            else
                            {
                                MessageBox.Show("Error: Unable to find the parent form.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
