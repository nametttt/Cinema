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

namespace Cinema
{
    public partial class WatchUser : Form
    {
        string connectionString = "Data Source=LAPTOP-KH7CD52O;Initial Catalog=Cinema;Integrated security=True";

        public WatchUser()
        {
            InitializeComponent();
        }

        private void WatchUser_Load(object sender, EventArgs e)
        {
            string query = "SELECT [User].UserID as Номер, [User].Email as Почта, Customer.Surname as Фамилия, Customer.Name as Имя, [User].UserRole as Роль " +
                " FROM [User] INNER JOIN Customer ON [User].UserID = Customer.UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            string query = "SELECT [User].UserID as Номер, [User].Email as Почта, Customer.Surname as Фамилия, Customer.Name as Имя, [User].UserRole as Роль " +
                " FROM [User] INNER JOIN Customer ON [User].UserID = Customer.UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            string query = "SELECT [User].UserID as Номер, [User].Email as Почта, Employee.Surname as Фамилия, Employee.Name as Имя, [User].UserRole as Роль " +
                " FROM [User] INNER JOIN Employee ON [User].UserID = Employee.UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView3.DataSource = dataTable;
            }
            }
        }
}
