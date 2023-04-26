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
    public partial class BuyTicket : Form
    {
        public BuyTicket()
        {
            InitializeComponent();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment mainForm = new Payment();
            mainForm.Show();
        }

        private void BuyTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
