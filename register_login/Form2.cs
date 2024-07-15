using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace register_login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string connection = "server=localhost;database=user;username=root;password=;";

            MySqlConnection conn = new MySqlConnection(connection);

            using (conn)
            {
                conn.Open();
                string cmd = "SELECT * FROM man WHERE userName = @name AND password = @pass";
                MySqlCommand mySqlCommand = new MySqlCommand(cmd, conn);
                mySqlCommand.Parameters.AddWithValue("@name", name);
                mySqlCommand.Parameters.AddWithValue("@pass", password);

                try
                {
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("success");
                        Form3 form = new Form3();
                        form.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("failed");

                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
