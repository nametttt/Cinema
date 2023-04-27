using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cinema
{
    public partial class ChangeSession : Form
    {
        string connectionString = "Data Source=LAPTOP-KH7CD52O;Initial Catalog=Cinema;Integrated security=True";
        public ChangeSession()
        {
            InitializeComponent();
        }

        private void ChangeSession_Load(object sender, EventArgs e)
        {
            using (CinemaEntities1 db = new CinemaEntities1())
            {
                foreach (Film f in db.Film)
                    txtFilm.Items.Add(f.Title);

                foreach (Room r in db.Room)
                    txtRoom.Items.Add(r.RoomID);

                foreach (Session s in db.Session)
                    txtSession.Items.Add(s.SessionID);

            }
            UpdateSession();
        }

        public void UpdateSession()
        {
            z.DataSource = null;
            string query = "SELECT Session.SessionID as Номер, Session.RoomID as Зал, Film.Title as Фильм, Session.SessionDate as Дата, Ticket.Price as Стоимость\r\nFROM   Session INNER JOIN\r\n             Ticket ON Session.SessionID = Ticket.SessionID INNER JOIN\r\n             Film ON Session.FilmID = Film.FilmID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                z.DataSource = dataTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (CinemaEntities1 db = new CinemaEntities1())
                {
                    if (txtFilm.SelectedItem == null || txtRoom.SelectedItem == null || sessiomDate.Text == "" || Price.Text == "" )
                    {
                        MessageBox.Show("Введите все данные!");
                    }
                    else
                    {
                        Session session = new Session(Convert.ToInt32(txtFilm.SelectedItem), Convert.ToInt32(txtRoom.SelectedItem), Convert.ToDateTime(sessiomDate.Text));
                        db.Session.Add(session);

                        Room room = new Room();
                        if (Convert.ToInt32(txtFilm.SelectedItem) == room.RoomID)
                        {
                            for (int i = 0; i < room.RowsCount; i++)
                            {
                                for (int j = 0; j < room.SeatsOfRowCount; j++)
                                {
                                    Ticket ticket = new Ticket();
                                    ticket.SessionID = session.SessionID;
                                    ticket.SeatID = i * room.SeatsOfRowCount + j + 1;
                                    ticket.Price = Convert.ToDecimal(Price.Text);

                                    db.Ticket.Add(ticket);
                                }
                            }
                        }

                        db.SaveChanges();
                        MessageBox.Show("Сеанс был добавлен успешно!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtFilm.SelectedItem = null;
                        txtRoom.SelectedItem = null;
                        sessiomDate.Text = "";
                        Price.Text = "";

                        UpdateSession();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }
    }
}
