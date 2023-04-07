using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.forms
{
    public partial class DeleteBookStock : Form
    {
        public DeleteBookStock()
        {
            InitializeComponent();
            DisplayData();
        }
        // Display data based on the specified category
        private void DisplayData(string category)
        {
            try
            {
                string query = $"SELECT * FROM bookTable WHERE category='{category}'";

                Connection connection = new Connection();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.thisConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                bookStockGridView.DataSource = dataTable;
                connection.thisConnection.Close();
            }
            catch (Exception ex)
            {
                errorDeleteBookLabel.Text = ex.Message;
            }
        }

        // Display all the data from the bookTable
        private void DisplayData()
        {
            try
            {
                string query = "SELECT * FROM bookTable";

                Connection connection = new Connection();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.thisConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                bookStockGridView.DataSource = dataTable;
                connection.thisConnection.Close();
            }
            catch (Exception ex)
            {
                errorDeleteBookLabel.Text = ex.Message;
            }
        }

        // Handle the delete book button click event
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = new Connection();
                string deleteQuery = $"DELETE FROM bookTable WHERE bookName= '{bookNameTextBox.Text}'";
                connection.thisConnection.Open();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection.thisConnection);

                int rowsAffected = cmd.ExecuteNonQuery();

                connection.thisConnection.Close();
                if (rowsAffected > 0)
                {
                    errorDeleteBookLabel.Text = $"{bookNameTextBox.Text} is deleted successfully";
                }
                else
                {
                    errorDeleteBookLabel.Text = $"{bookNameTextBox.Text} is not found in the database.";
                }

            }
            catch (Exception ex)
            {
                errorDeleteBookLabel.Text = ex.Message;
            }
        }

        // Handle the search button click event
        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayData(categoryComboBox.Text);
        }

        // Handle the refresh button click event
        private void refreshButton_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        // Other event handlers
        private void bookStockGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
