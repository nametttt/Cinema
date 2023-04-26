using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1()) 
            {
                try
                {
                    if (Login.Text == "" || Password.Text == "" || UserSurname.Text == "" || UserName.Text == "")
                    {
                        MessageBox.Show("Заполните все данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if(!IsValidEmail(Login.Text)) 
                        {
                            MessageBox.Show("Введите корректную почту!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Password.Text.Length < 6)
                        {
                            MessageBox.Show("Слишком короткий пароль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            User user = new User(Login.Text, GetHashString(Password.Text), "роль");
                            Customer customer = new Customer(user.UserID, UserSurname.Text, UserName.Text);
                            db.User.Add(user);
                            db.Customer.Add(customer);
                            db.SaveChanges();
                            MessageBox.Show("Регистрация прошла успешно.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record mainForm = new Record();
            mainForm.Show();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }

        private void Reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }
    }
}
