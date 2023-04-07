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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }
        private void datashow(string dest)
        {
            try
            {
                string querry;
                querry = "SELECT * FROM bookTable where category='" + dest + "'";

                Connection CN = new Connection();

                MySqlDataAdapter sda = new MySqlDataAdapter(querry, CN.thisConnection);

                DataTable fatable = new DataTable();
                sda.Fill(fatable);
                dataGridView1.DataSource = fatable;
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                errorsearchBook.Text = ex.Message;
            }

        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datashow(categoryComboBox.Text);
        }
    }
}
