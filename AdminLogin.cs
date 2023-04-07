using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.forms
{
    public partial class AdminLogin : Form
    {
        string querry;

        public HomePage hmp;
        public AdminLogin(HomePage HomePage)
        {
            this.hmp = HomePage;
            InitializeComponent();
        }

        private void logincheck()
        {
            try
            {

                Connection CN = new Connection();
                querry = "SELECT * FROM ADMINLOGINinfo WHERE id='" + idBoxAdmin.Text + "' AND password='" + passBoxAdmin.Text + "'";

                MySqlDataAdapter sda = new MySqlDataAdapter(querry, CN.thisConnection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    AdminPage oform = new AdminPage(hmp);
                    oform.Show();
                    passBoxAdmin.Clear();
                    hmp.Hide();

                }
                else
                {
                    adminLoginInfo.Text = "Admin: username or password incorrect";
                    passBoxAdmin.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                adminLoginInfo.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.logincheck();
        }

        private void errorAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void passBoxAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
