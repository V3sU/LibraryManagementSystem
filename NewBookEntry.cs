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
    public partial class NewBookEntry : Form
    {
        public NewBookEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                string bk_insert = "INSERT INTO bookTable (bookName, bookPublishedYear, writerName, quantity, category, entryDate) VALUES('" + bookTextBox.Text + "', '" + bookPublishYearComboBox.Text + "', '" + writerNameTextBox.Text + "', '" + quantityTextBox.Text + "', '" + categoryComboBox.Text + "', '" + entryDateTimePicker.Text + "'); ";
                CN.thisConnection.Open();
                MySqlCommand cmcd = new MySqlCommand(bk_insert, CN.thisConnection);

                cmcd.ExecuteNonQuery();

                CN.thisConnection.Close();
                ERRORLAvEL.Text = " Data Saved";

            }
            catch (Exception ex)
            {
                ERRORLAvEL.Text = ex.Message;
            }

        }
    }
}
