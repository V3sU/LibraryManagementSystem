using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Forms
{
    public partial class AdminLoginForm : Form
    {
        string query;

        public HomePage HomePageRef;
        public AdminLoginForm(HomePage homePage)
        {
            this.HomePageRef = homePage;
            InitializeComponent();
        }

        // Method to check login credentials
        private void CheckLoginCredentials()
        {
            try
            {
                Connection connection = new Connection();
                query = "SELECT * FROM ADMINLOGINinfo WHERE id='" + userIdTextBox.Text + "' AND password='" + passwordTextBox.Text + "'";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.ThisConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    AdminPage adminPage = new AdminPage(HomePageRef);
                    adminPage.Show();
                    passwordTextBox.Clear();
                    HomePageRef.Hide();
                }
                else
                {
                    adminLoginInfoLabel.Text = "Admin: username or password incorrect";
                    passwordTextBox.Clear();
                }
                
                connection.ThisConnection.Close();
            }
            catch (Exception ex)
            {
                adminLoginInfoLabel.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        // Login button click event handler
        private void LoginButton_Click(object sender, EventArgs e)
        {
            CheckLoginCredentials();
        }

        private void ErrorAdminLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
