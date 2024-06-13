using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    
    public partial class Login : Form
    {
        public static string user;
        public static string pass;

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
        public Login()
        {
            InitializeComponent();
            passTextBox.UseSystemPasswordChar = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passTextBox.UseSystemPasswordChar = false;

            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
            
            user = usernameTextBox.Text;
             pass = passTextBox.Text;



            if (!string.IsNullOrEmpty(CardIDTextBox.Text))
            {
                int cardid;
                if (int.TryParse(CardIDTextBox.Text, out cardid))
                {
                    Hide();
                    Loggin login = new Loggin(cardid, user, pass);
                }
                else
                {
                    MessageBox.Show("Invalid Card ID. Please enter a valid number.");
                }
            }
            else
            {
                Hide();
             
                Dashboard dashboard = new Dashboard(user, pass);
                dashboard.adminlogin(user, pass);
            }
        }




    }
}

