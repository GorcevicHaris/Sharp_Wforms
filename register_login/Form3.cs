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

            MySqlConnection conn = new MySqlConnection(connection);
            {
                conn.Open();
                string sql = "SELECT * FROM man"; // Include the 'id' column
                MySqlCommand db = new MySqlCommand(sql, conn);
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(db);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
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

            MySqlConnection conn = new MySqlConnection(connection);
            {
                conn.Open();

                string sql = "INSERT INTO man (userName, password) VALUES (@userName, @password)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    string connection = "server=localhost;database=user;username=root;password=;";
                    MySqlConnection mySqlConnection = new MySqlConnection(connection);
                    {
                        mySqlConnection.Open();
                        string sql = "DELETE FROM man WHERE id = @id";
                        MySqlCommand db = new MySqlCommand(sql, mySqlConnection);
                        db.Parameters.AddWithValue("@id", userId);
                        db.ExecuteNonQuery();
                        MessageBox.Show("User deleted successfully");
                        LoadData();
                    }
                }
                else { MessageBox.Show("Select user which u want to delete"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string userName = textBox1.Text;
                    string password = textBox2.Text;
                    int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                    string connection = "server=localhost;database=user;username=root;password=;";
                    using (MySqlConnection mySqlConnection = new MySqlConnection(connection))
                    {
                        mySqlConnection.Open();
                        string sql = "UPDATE man SET userName = @userName, password = @password WHERE id = @userID";
                        using (MySqlCommand db = new MySqlCommand(sql, mySqlConnection))
                        {
                            db.Parameters.AddWithValue("@userName", userName);
                            db.Parameters.AddWithValue("@password", password);
                            db.Parameters.AddWithValue("@userID", userId);

                            db.ExecuteNonQuery();
                        }
                    }

                    LoadData();
                    MessageBox.Show("User is successfully updated");
                }
                else
                {
                    MessageBox.Show("Select user which you want to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}