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
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 70, 70));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDCard iDCard = new IDCard();
            Hide();
            iDCard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Hide();
            Dashboard.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            History history = new History();
            Hide();
            history.ShowDialog();
        }
    }
}
