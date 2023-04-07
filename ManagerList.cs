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
    public partial class ManagerList : Form
    {
        string query;

        public ManagerList()
        {
            InitializeComponent();
            LoadManagerData();
        }

        // Method to fetch manager data and display it in a DataGridView
        private void LoadManagerData()
        {
            Connection connection = new Connection();
            query = "SELECT * FROM MANAGERLOGININFO";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection.thisConnection);
            DataTable managerTable = new DataTable();
            dataAdapter.Fill(managerTable);
            dataGridView1.DataSource = managerTable;
            connection.thisConnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerList_Load(object sender, EventArgs e)
        {

        }

        // Refreshes the manager list data when the refresh button is clicked
        private void refresh_Click(object sender, EventArgs e)
        {
            LoadManagerData();
        }
    }
}
