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

namespace LibraryManagementSystem.Forms
{
    public partial class UpdateBookStockForm : Form
    {
        private string _bookFetchQuery, _bookUpdateQuery;
        private Connection _connection = new Connection();

        public UpdateBookStockForm()
        {
            InitializeComponent();
        }

        private void UpdateBookStockForm_Load(object sender, EventArgs e)
        {

        }

        // Fetches book details when the book name is entered.
        private void BookNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _bookFetchQuery = "SELECT bookName, bookPublishedYear, writerName, quantity, category, entryDate FROM bookTable where bookName= '" + BookNameTextBox.Text + "'";
                _connection.ThisConnection.Open();

                MySqlCommand fetchCommand = new MySqlCommand(_bookFetchQuery, _connection.ThisConnection);
                MySqlDataReader dataReader = fetchCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    BookNameBoxUp.Text = dataReader.GetValue(0).ToString();
                    PublishedYearComboBox.Text = dataReader.GetValue(1).ToString();
                    WriterNameTextBox.Text = dataReader.GetValue(2).ToString();
                    QuantityTextBox.Text = dataReader.GetValue(3).ToString();
                    CategoryComboBox.Text = dataReader.GetValue(4).ToString();
                    EntryDatePicker.Text = dataReader.GetValue(5).ToString();
                }
                _connection.ThisConnection.Close();
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }

        // Updates book stock and details when the 'Update' button is clicked.
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _bookUpdateQuery = "UPDATE bookTable SET bookName = '" + BookNameBoxUp.Text + "' , bookPublishedYear = '" + PublishedYearComboBox.Text + "', writerName = '" + WriterNameTextBox.Text + "', quantity = '" + NewQuantityTextBox.Text + "', category = '" + CategoryComboBox.Text + "', entryDate = '" + EntryDatePicker.Text + "'  WHERE bookName= '" + BookNameTextBox.Text + "' ";
                _connection.ThisConnection.Open();
                MySqlCommand updateCommand = new MySqlCommand(_bookUpdateQuery, _connection.ThisConnection);

                updateCommand.ExecuteNonQuery();

                _connection.ThisConnection.Close();
                ErrorLabel.Text = " Data updated";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }
    }
}
