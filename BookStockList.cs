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
    public partial class BookStockListForm : Form
    {
        public BookStockListForm()
        {
            InitializeComponent();
            DisplayData();
        }

        // Method to display the data from the database
        private void DisplayData()
        {
            Connection connection = new Connection();
            string query = "SELECT * FROM bookTable";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.ThisConnection);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            bookStockGridView.DataSource = dataTable;
            connection.ThisConnection.Close();
        }

        // Event handler for the Refresh button
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
