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

namespace LibraryManagementSystem.Forms
{
    public partial class NewBookEntryForm : Form
    {
        public NewBookEntryForm()
        {
            InitializeComponent();
        }

        private void OnPublishYearSelected(object sender, EventArgs e)
        {
            // Handle the selection event for the publish year combo box
        }

        private void OnTitleTextChanged(object sender, EventArgs e)
        {
            // Handle the text changed event for the title text box
        }

        private void OnEntryDateChanged(object sender, EventArgs e)
        {
            // Handle the value changed event for the entry date picker
        }

        private void OnInsertButtonClick(object sender, EventArgs e)
        {
            try
            {
                // Create a new database connection
                using (var connection = new MySqlConnection("Your Connection String"))
                {
                    // Create a new command for inserting a book
                    var insertBookCommand = new MySqlCommand
                    {
                        Connection = connection,
                        CommandText = "INSERT INTO Books (Title, PublishYear, Author, Quantity, Category, EntryDate) " +
                                      "VALUES (@Title, @PublishYear, @Author, @Quantity, @Category, @EntryDate)"
                    };

                    // Add parameters to the command
                    insertBookCommand.Parameters.AddWithValue("@Title", titleTextBox.Text);
                    insertBookCommand.Parameters.AddWithValue("@PublishYear", publishYearComboBox.Text);
                    insertBookCommand.Parameters.AddWithValue("@Author", authorTextBox.Text);
                    insertBookCommand.Parameters.AddWithValue("@Quantity", int.Parse(quantityTextBox.Text));
                    insertBookCommand.Parameters.AddWithValue("@Category", categoryComboBox.Text);
                    insertBookCommand.Parameters.AddWithValue("@EntryDate", entryDatePicker.Value);

                    // Open the connection, execute the command, and close the connection
                    connection.Open();
                    insertBookCommand.ExecuteNonQuery();
                    connection.Close();

                    // Show a success message
                    errorLabel.Text = "Data saved successfully.";
                }
            }
            catch (Exception ex)
            {
                // Display the error message
                errorLabel.Text = $"Error: {ex.Message}";
            }
        }
    }
}
