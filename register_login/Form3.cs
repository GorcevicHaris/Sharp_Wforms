using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace register_login
{
    public partial class Form3 : Form
    {
        private string currentUserName;
        public Form3(string userName)
        {
            InitializeComponent();
            label7.Text = userName;
            //label7.Text = currentUserName;
            LoadData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            //NameOfUser();
        }

        //private void NameOfUser()
        //{
        //    string connection = "server=localhost;database=user;username=root;password=;";
        //    MySqlConnection conn = new MySqlConnection(connection);
        //    try
        //    {
        //        conn.Open();
        //        string sql = "SELECT userName FROM man WHERE userName = @userName";
        //        MySqlCommand db = new MySqlCommand(sql, conn);
        //        db.Parameters.AddWithValue("@userName", currentUserName);

        //        MySqlDataReader reader = db.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            label7.Text = currentUserName;
        //        }
        //        else
        //        {
        //            MessageBox.Show("User not found");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}


        private void LoadData()
        {
            string connection = "server=localhost;database=user;username=root;password=;";

            MySqlConnection conn = new MySqlConnection(connection);
            {
                conn.Open();
                string sql = "SELECT * FROM man";
                MySqlCommand db = new MySqlCommand(sql, conn);
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(db);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRows = dataGridView1.SelectedRows;
                textBox2.Text = selectedRows[0].Cells["userName"].Value.ToString();
                textBox1.Text = selectedRows[0].Cells["password"].Value.ToString();
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
            int roomNumber;
            string userName = textBox2.Text.Trim();
            string password = textBox1.Text.Trim();
            if (!int.TryParse(textBox3.Text, out roomNumber))
            {
                MessageBox.Show("Unesite broj");
                return;
            }
            string connection = "server=localhost;database=user;username=root;password=;";

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();

                string Selectsql = "SELECT roomNum FROM man WHERE roomNum = @roomNum";
                MySqlCommand dbQ = new MySqlCommand(Selectsql, conn);
                dbQ.Parameters.AddWithValue("@roomNum", roomNumber);

                using (var reader = dbQ.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int existingRoomNumber = Convert.ToInt32(reader["roomNum"]);
                        if (existingRoomNumber == roomNumber)
                        {

                            MessageBox.Show("Soba sa tim brojem već postoji." + reader);
                            return;
                        }
                    }
                }


                string sql = "INSERT INTO man (userName, password, roomNum) VALUES (@userName, @password, @roomNum)";
                MySqlCommand db = new MySqlCommand(sql, conn);
                db.Parameters.AddWithValue("@userName", userName);
                db.Parameters.AddWithValue("@password", password);
                db.Parameters.AddWithValue("@roomNum", roomNumber);
                db.ExecuteNonQuery();
                MessageBox.Show("Korisnik uspešno dodat.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri unosu korisnika: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
                else
                {
                    MessageBox.Show("Select user which u want to delete");
                }

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
                    int roomNum = Convert.ToInt32(textBox3.Text);
                    string userName = textBox2.Text;
                    string password = textBox1.Text;
                    dataGridView1.CurrentRow.Cells["userName"].Value = userName;
                    dataGridView1.CurrentRow.Cells["password"].Value = password;
                    dataGridView1.CurrentRow.Cells["roomNum"].Value = roomNum;
                    int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                    string connection = "server=localhost;database=user;username=root;password=;";
                    using (MySqlConnection mySqlConnection = new MySqlConnection(connection))
                    {
                        mySqlConnection.Open();
                        string sql = "UPDATE man SET userName = @userName, password = @password, roomNum = @roomNum WHERE id = @userID";
                        using (MySqlCommand db = new MySqlCommand(sql, mySqlConnection))
                        {
                            db.Parameters.AddWithValue("@userName", userName);
                            db.Parameters.AddWithValue("@password", password);
                            db.Parameters.AddWithValue("@roomNum", roomNum);
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        
    }
}