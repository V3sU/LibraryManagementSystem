using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.forms
{
    public partial class AdminPage : Form
    {
        HomePage hmpg;
        
        ManagerList adm1 = new ManagerList();
        NewManagerEntr adm2 = new NewManagerEntr();
        ManagerDelete adm3 = new ManagerDelete();
        public AdminPage(HomePage HomePage)
        {
            this.hmpg = HomePage;            
            InitializeComponent();
            loadform(adm1);
            
        }
        public void loadform(object Form)
        {
            if (this.mainPanelAdmin.Controls.Count > 0)
            {
                this.mainPanelAdmin.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelAdmin.Controls.Add(f);
            this.mainPanelAdmin.Tag = f;
            f.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(adm1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(adm2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(adm3);
        }
    }
}
