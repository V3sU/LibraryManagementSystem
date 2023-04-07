using System;
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
    public partial class ManagerDeletionForm : Form
    {
        public ManagerDeletionForm()
        {
        InitializeComponent();
        }
            private void ManagerDeletionForm_Load(object sender, EventArgs e)
    {
        // This method is called when the form is loaded
    }

    private void titleLabel_Click(object sender, EventArgs e)
    {
        // This method handles titleLabel click event
    }

    private void DeleteManagerButton_Click(object sender, EventArgs e)
    {
        try
        {
            // Create a connection to the database
            Connection connection = new Connection();

            // Define the SQL query for deleting the manager by ID
            string deleteQuery = "DELETE FROM MANAGERLOGININFO WHERE ID= '" + managerIdTextBox.Text + "'";
            connection.thisConnection.Open();

            // Execute the query
            MySqlCommand command = new MySqlCommand(deleteQuery, connection.thisConnection);
            command.ExecuteNonQuery();

            // Close the connection
            connection.thisConnection.Close();

            // Update the status label with the result
            errorLabel.Text = managerIdTextBox.Text + " deleted successfully";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void managerIdLabel_Click(object sender, EventArgs e)
    {
        // This method handles managerIdLabel click event
    }
}
