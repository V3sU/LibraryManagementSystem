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
    public partial class NewManagerEntr : Form
    {
        public NewManagerEntr()
        {
            InitializeComponent();
        }

        private void NewManagerEntr_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Connection CN = new Connection();
            string sp_insert = "INSERT INTO MANAGERLOGININFO (ID, PASSWORD) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "'); ";
            CN.thisConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sp_insert, CN.thisConnection);

            int i = cmd.ExecuteNonQuery();

            CN.thisConnection.Close();
            if (i > 0)
            {
                ERRORLABEL.Text = i+" Data Saved";
            }

        }
    }
}


