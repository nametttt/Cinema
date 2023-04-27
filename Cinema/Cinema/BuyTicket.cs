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
            using (var db = new CinemaEntities1())
            {
                foreach (var entity in db.Seat) 
                {
                    for(int i = 0; i < 31; i++)
                    {
                        if (entity.Seat1 == i)
                        {
                            string buttonName = "button" + i;

                            // поиск элемента управления по его имени
                            Control[] foundControls = this.Controls.Find(buttonName, true);

                            // проверяем, нашли ли мы элемент управления
                            if (foundControls.Length > 0 && foundControls[0] is Button)
                            {
                                // получаем экземпляр кнопки по ее имени
                                Button myButton = (Button)foundControls[0];
                                myButton.BackColor = Color.Black;

                                // далее можно использовать myButton в вашем коде
                            }
                        }
                        // название кнопки, которую мы хотим получить
                       
                    }
                }
            }
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
