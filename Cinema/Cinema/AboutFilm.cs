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
    public partial class AboutFilm : Form
    {
        public AboutFilm()
        {
            InitializeComponent();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainForm = new MainWindow();
            mainForm.Show();
        }

        private void купитьБилетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule mainForm = new Schedule();
            mainForm.Show();
        }

        private void списокФильмовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutCinema mainForm = new AboutCinema();
            mainForm.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyCab mainForm = new MyCab();
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket mainForm = new BuyTicket();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mainForm = new MainWindow();
            mainForm.Show();
        }

        private void AboutFilm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
