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
    public partial class MyCab : Form
    {
        public MyCab()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MyCab_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
