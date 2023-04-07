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
    public partial class ManagerPage : Form
    {
        HomePage hmpg;
        
        NewBookEntry mng1 = new NewBookEntry();
        UpdateBookStock mng2 = new UpdateBookStock();
        SearchBook mng3 = new SearchBook();
        DeleteBookStock mng4 = new DeleteBookStock();
        BookStockList mng5 = new BookStockList();

        public ManagerPage(HomePage HomePage)
        {
            this.hmpg = HomePage;   
            InitializeComponent();
            loadform(mng1);
        }
        public void loadform(object Form)
        {
            if (this.mainPanelManagerPage.Controls.Count > 0)
            {
                this.mainPanelManagerPage.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelManagerPage.Controls.Add(f);
            this.mainPanelManagerPage.Tag = f;
            f.Show();
        }

        private void ManagerPage_Load(object sender, EventArgs e)
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
            loadform(mng1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(mng2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(mng3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(mng4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(mng5);
        }
    }
}
