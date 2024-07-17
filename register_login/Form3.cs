using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace register_login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connection = "server=localhost;database=user;username=root;password=;";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string sql = "SELECT userName, password FROM man";
                using (MySqlCommand db = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(db);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim(); 
            string password = textBox2.Text.Trim(); 



            string connection = "server=localhost;database=user;username=root;password=;";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string sql = "INSERT INTO man (userName, password) VALUES (@userName, @password)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User added successfully.");

                    LoadData();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
