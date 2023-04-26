using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("tanushacinema@mail.ru", "Tanya");
            MailAddress to = new MailAddress(textBoxEmail.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Сброс пароля для приложения";
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (User user in db.User)
                {
                    if (textBoxEmail.Text == user.Email)
                    {
                        m.Body = "<h1>Пароль: " + user.UserPassword + "</h1>";
                    }
                }
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("tanushacinema@mail.ru","eKwSyxx2Qbhfx3UED3gy");
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Сообщение с инструкцией отправлено на почту!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth mainForm = new Auth();
            mainForm.Show();
        }

        private void Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
