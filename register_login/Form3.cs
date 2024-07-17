using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string connection = "server=localhost;database=user;username=root;password=;";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string sql = "SELECT * FROM man";
                using (MySqlCommand db = new MySqlCommand(sql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(db);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    //Label[] array = new Label[dt.Rows.Count];

                    //int leftPosition = 20;
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    array[i] = new Label();
                    //    array[i].Text = dt.Rows[i]["userName"].ToString();
                    //    array[i].Left = leftPosition;
                    //    array[i].Top = 30 * i;
                    //    leftPosition += array[i].Width + 10; 
                    //    this.Controls.Add(array[i]);
                    //}

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
