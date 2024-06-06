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

namespace TechnoSystem
{
    public partial class Login : Form
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

            string user = usernameTextBox.Text;
            string pass = passTextBox.Text;
            if (user.Equals("1") && (pass.Equals("1")))
            {

               Dashboard dashboard = new Dashboard();
                Hide();
                dashboard.ShowDialog();
            }
            else if (user.Equals(user) && (pass.Equals(pass)))
            {
                Loggin login = new Loggin(user, pass);
            }
        }
    }
}
