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
    public partial class AdminiForm : Form
    {
        public AdminiForm()
        {
            InitializeComponent();
        }

        private void AdminiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeFilms mainForm = new ChangeFilms();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeSession mainForm = new ChangeSession();
            mainForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WatchDoc mainForm = new WatchDoc();
            mainForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            WatchUser mainForm = new WatchUser();
            mainForm.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }
    }
}
