using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.forms
{
    public partial class ManagerLoginForm : Form
    {
        string query;
        HomePage homePage;
        
        // Constructor with a reference to the HomePage form
        public ManagerLoginForm(HomePage homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
        }
        
        // Method to check the manager login credentials
        private void CheckLoginCredentials()
        {
            try
            {
                Connection connection = new Connection();
                query = "SELECT * FROM MANAGERLOGININFO WHERE id='" + userIdTextBox.Text + "' AND password='" + passwordTextBox.Text + "'";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.thisConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    ManagerPage managerPage = new ManagerPage(homePage);
                    managerPage.Show();
                    passwordTextBox.Clear();
                    homePage.Hide();
                }
                else
                {
                    loginInfoLabel.Text = "Admin: username or password incorrect";
                    passwordTextBox.Clear();
                }

                connection.thisConnection.Close();
            }
            catch (Exception ex)
            {
                loginInfoLabel.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        private void ManagerLoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            CheckLoginCredentials();
        }
    }
}
