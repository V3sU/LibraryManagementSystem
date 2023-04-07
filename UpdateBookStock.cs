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
    public partial class UpdateBookStock : Form
    {
        private string bk_fetch,bk_update;
        Connection CN = new Connection();

        public UpdateBookStock()
        {
            InitializeComponent();
        }

        private void UpdateBookStock_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bk_fetch = "SELECT bookName, bookPublishedYear, writerName, quantity, category, entryDate FROM bookTable where bookName= '" + textBox1.Text + "'";
                CN.thisConnection.Open();

                MySqlCommand sdaa = new MySqlCommand(bk_fetch, CN.thisConnection);

                MySqlDataReader da = sdaa.ExecuteReader();

                while (da.Read())
                {
                    bookNameBoxup.Text = da.GetValue(0).ToString();
                    comboBox2.Text = da.GetValue(1).ToString();
                    textBox2.Text = da.GetValue(2).ToString();
                    textBox3.Text = da.GetValue(3).ToString();
                    comboBox3.Text = da.GetValue(4).ToString();
                    dateTimePicker1.Text = da.GetValue(5).ToString();
                }
                CN.thisConnection.Close();
            }
            
            catch(Exception ex)
            {
                ERRORLAvEL.Text = ex.Message;
            }
            //ERRORLAvEL
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bk_update = "UPDATE bookTable SET bookName = '" + bookNameBoxup.Text + "' , bookPublishedYear = '" + comboBox2.Text + "', writerName = '" + textBox2.Text + "', quantity = '" + textBox4.Text + "', category = '" + comboBox3.Text + "', entryDate = '" + dateTimePicker1.Text + "'  WHERE bookName= '" + textBox1.Text + "' ";
                CN.thisConnection.Open();
                MySqlCommand cmcd = new MySqlCommand(bk_update, CN.thisConnection);

                cmcd.ExecuteNonQuery();

                CN.thisConnection.Close();
                ERRORLAvEL.Text = " Data updated";

            }
            catch (Exception ex)
            {
                ERRORLAvEL.Text = ex.Message;
            }
        }
    }
}
