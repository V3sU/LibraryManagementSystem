using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.forms
{
    public partial class ManagerLogin : Form
    {
        string querry;
        HomePage hmp;
        public ManagerLogin(HomePage HomePage)
        {
            this.hmp = HomePage;
            InitializeComponent();
        }
        private void logincheck()
        {
            try
            {

                Connection CN = new Connection();
                querry = "SELECT * FROM MANAGERLOGININFO WHERE id='" + idBoxManager.Text + "' AND password='" + passBoxManager.Text + "'";

                MySqlDataAdapter sda = new MySqlDataAdapter(querry, CN.thisConnection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    ManagerPage oform2 = new ManagerPage(hmp);
                    oform2.Show();
                    passBoxManager.Clear();
                    hmp.Hide();

                }
                else
                {
                    managerLoginInfo.Text = "Admin: username or password incorrect";
                    passBoxManager.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                managerLoginInfo.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        private void HomePageManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.logincheck();
        }
    }
}
