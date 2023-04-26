using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class AboutCinema : Form
    {
        public AboutCinema()
        {
            InitializeComponent();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainForm = new MainWindow();
            mainForm.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyCab mainForm = new MyCab();
            mainForm.Show();
        }

        private void AboutCinema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void РасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Schedule mainForm = new Schedule();
            mainForm.Show();
        }
    }
}
