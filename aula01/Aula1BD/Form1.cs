using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace Aula1BD
{
    public partial class Form1 : Form
    {
        private void TestDBConnection(string dbServer, string dbName, string userName, string userPass)
        {
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName +
                                                       "; uid = " + userName + ";" + "password = " + userPass + ";Encrypt=false");

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();
        }


        private string getTableContent(SqlConnection CN)
        {
            string str = "";

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    int cnt = 1;
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Hello", CN);
                    SqlDataReader reader;
                    reader = sqlcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        str += cnt.ToString() + " - " + reader.GetInt32(reader.GetOrdinal("MsgID")) + ", ";
                        str += reader.GetString(reader.GetOrdinal("MsgSubject"));
                        str += "\n";
                        cnt += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Error", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();

            return str;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = "pXgY"; 
            string user = txtUser.Text;
            string pass = txtPass.Text;

            SqlConnection CN = new SqlConnection(
                "Data Source=" + server + ";Initial Catalog=" + database + ";uid=" + user + ";password=" + pass + ";Encrypt=false"
            );

            string conteudo = GetTableContent(CN);
            MessageBox.Show(conteudo, "Dump Hello Table", MessageBoxButtons.OK);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string server = txtServer.Text;
            string database = "pXgY"; 
            string user = txtUser.Text;
            string pass = txtPass.Text;

            TestDBConnection(server, database, user, pass);
        }

        

    }
}
