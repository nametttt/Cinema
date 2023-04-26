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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutFilm mainForm = new AboutFilm();
            mainForm.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutFilm mainForm = new AboutFilm();
            mainForm.Show();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket mainForm = new BuyTicket();
            mainForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutFilm mainForm = new AboutFilm();
            mainForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutFilm mainForm = new AboutFilm();
            mainForm.Show();
        }
    }
}
