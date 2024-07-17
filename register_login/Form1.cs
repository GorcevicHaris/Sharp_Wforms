using MySql.Data;
using MySql.Data.MySqlClient;
namespace register_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string coonection = "server=localhost;database=user;username=root;password=;";

            MySqlConnection conn = new MySqlConnection(coonection);
            using (conn)
            {
                conn.Open();
                string cmd = "INSERT INTO man (userName,password) VALUES(@userName,@password)";
                MySqlCommand cmd2 = new MySqlCommand(cmd, conn);
                cmd2.Parameters.AddWithValue("@userName", username);
                cmd2.Parameters.AddWithValue("@password", password);
                try
                {
                    int status = cmd2.ExecuteNonQuery();
                    if (status > 0)
                    {
                        MessageBox.Show("success");
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("failed");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString()+ "dal");
                }
            }
        }
    }
}
