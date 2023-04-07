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
            datashow();
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
                errorDeleteBook.Text = ex.Message;
            }

        }
        private void datashow()
        {
            try
            {
                string querry;
                querry = "SELECT * FROM bookTable";

                Connection CN = new Connection();

                MySqlDataAdapter sda = new MySqlDataAdapter(querry, CN.thisConnection);

                DataTable fatable = new DataTable();
                sda.Fill(fatable);
                dataGridView1.DataSource = fatable;
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                errorDeleteBook.Text = ex.Message;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                string sp_delete = "Delete from bookTable where bookName= '" + this.theValuetextBox.Text + "'";
                CN.thisConnection.Open();
                MySqlCommand cmd = new MySqlCommand(sp_delete, CN.thisConnection);

                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i >0)
                {
                    errorDeleteBook.Text = theValuetextBox.Text + " is deleted successfully";
                }
                else
                {
                    errorDeleteBook.Text = theValuetextBox.Text + " is not found in database.";
                }
                

            }
            catch (Exception ex)
            {
                errorDeleteBook.Text= ex.Message;
            }
            //errorDeleteBook
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datashow(categoryComboBox.Text);
            //categoryComboBox
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            datashow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
