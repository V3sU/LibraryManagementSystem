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
    public partial class BookSearchForm : Form
    {
        public BookSearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays books with the specified category in the data grid view.
        /// </summary>
        /// <param name="category">The book category to search for.</param>
        private void DisplayBooksByCategory(string category)
        {
            try
            {
                string query = "SELECT * FROM bookTable WHERE category='" + category + "'";

                Connection connection = new Connection();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.ThisConnection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                booksDataGridView.DataSource = dataTable;
                connection.ThisConnection.Close();
            }
            catch (Exception ex)
            {
                searchErrorLabel.Text = ex.Message;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DisplayBooksByCategory(categoryComboBox.Text);
        }
    }
}
