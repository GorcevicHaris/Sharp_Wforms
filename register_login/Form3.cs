using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.IO;
using System.Net;

namespace register_login
{
    public partial class Form3 : Form
    {

        public Form3(string userName)
        {

            InitializeComponent();
            label7.Text = userName;
            LoadData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        //MySqlConnection connection = new MySqlConnection("server=localhost;database=user;username=root;password=;");




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
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.RowTemplate.Height = 60;
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRows = dataGridView1.SelectedRows;
                textBox1.Text = selectedRows[0].Cells["password"].Value.ToString();
                textBox2.Text = selectedRows[0].Cells["userName"].Value.ToString();
                textBox3.Text = selectedRows[0].Cells["roomNum"].Value.ToString();
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            //cuvamo sliku u niz bajtova mora tako
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
                string sql = "INSERT INTO man (userName, password, roomNum,IMG) VALUES (@userName, @password, @roomNum, @img)";
                MySqlCommand db = new MySqlCommand(sql, conn);
                db.Parameters.AddWithValue("@userName", userName);
                db.Parameters.AddWithValue("@password", password);
                db.Parameters.AddWithValue("@roomNum", roomNumber);
                db.Parameters.AddWithValue("@img", img);

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

        private void GoToForm4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Chose Image(*.JPG;*.PNG;*GIF;)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}