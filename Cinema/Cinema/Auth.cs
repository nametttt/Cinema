using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                try
                {
                    foreach (User user in db.User)
                    {
                        if (Login.Text == user.Email && this.GetHashString(Password.Text) == user.UserPassword && user.UserRole == "Покупатель")
                        {
                            MessageBox.Show($"Добро пожаловать!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainWindow userform = new MainWindow();
                            userform.Show();
                            this.Hide();
                            return;
                        }

                        else if (Login.Text == user.Email && this.Password.Text == user.UserPassword && user.UserRole == "Менеджер")
                        {
                            MessageBox.Show($"Добро пожаловать!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ManagerForm managerForm = new ManagerForm();
                            managerForm.Show();
                            this.Hide();
                            return;
                        }

                        else if (Login.Text == user.Email && this.Password.Text == user.UserPassword && user.UserRole == "Кассир")
                        {
                            MessageBox.Show($"Добро пожаловать!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KassirForm managerForm = new KassirForm();
                            managerForm.Show();
                            this.Hide();
                            return;
                        }
                        else if (Login.Text == user.Email && this.Password.Text == user.UserPassword && user.UserRole == "Администратор")
                        {
                            MessageBox.Show($"Добро пожаловать!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminiForm managerForm = new AdminiForm();
                            managerForm.Show();
                            this.Hide();
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка!");
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg mainForm = new Reg();
            mainForm.Show();
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
