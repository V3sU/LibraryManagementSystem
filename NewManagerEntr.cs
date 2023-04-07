using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.forms
{
    public partial class NewManagerEntryForm : Form
    {
        public NewManagerEntryForm()
        {
            InitializeComponent();
        }

        private void OnNewManagerEntryFormLoad(object sender, EventArgs e)
        {
            // This method is called when the form is loaded. You can add any initialization code here.
        }

        // This method is triggered when the "Create" button is clicked.
        private void OnCreateButtonClick(object sender, EventArgs e)
        {
            // Create a new Connection object.
            Connection connection = new Connection();

            // Define the SQL query for inserting a new manager login entry.
            string insertQuery = "INSERT INTO MANAGERLOGININFO (ID, PASSWORD) VALUES('" + managerIdTextBox.Text + "', '" + passwordTextBox.Text + "'); ";

            // Open the connection to the database.
            connection.thisConnection.Open();

            // Create a new MySqlCommand object for executing the SQL query.
            MySqlCommand cmd = new MySqlCommand(insertQuery, connection.thisConnection);

            // Execute the SQL query and get the number of affected rows.
            int affectedRows = cmd.ExecuteNonQuery();

            // Close the connection to the database.
            connection.thisConnection.Close();

            // Display a success message if any rows were affected.
            if (affectedRows > 0)
            {
                errorLabel.Text = affectedRows + " Data Saved";
            }
        }
    }
}
