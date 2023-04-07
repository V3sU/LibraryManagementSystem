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
    public partial class ManagerDelete : Form
    {
        public ManagerDelete()
        {
            InitializeComponent();
        }

        private void ManagerDelete_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteManagerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                string sp_delete = "Delete from MANAGERLOGININFO where ID= '" + this.DeleteIdBoxManager.Text + "'";
                CN.thisConnection.Open();
                MySqlCommand cmd = new MySqlCommand(sp_delete, CN.thisConnection);

                cmd.ExecuteNonQuery();

                CN.thisConnection.Close();

                ERRORLABEL.Text = DeleteIdBoxManager.Text + " deleted successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //DeleteIdBoxManager
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
