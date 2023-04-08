using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    // Admin page form that provides access to different manager-related features
    public partial class AdminPageForm : Form
    {
        private HomePageForm homePageForm;
        private ManagerListForm managerListForm;
        private NewManagerEntryForm newManagerEntryForm;
        private ManagerDeleteForm managerDeleteForm;

        public AdminPageForm(HomePageForm homePageForm)
        {
            // Initialize the form and load the manager list form by default
            this.homePageForm = homePageForm;            
            InitializeComponent();
            LoadForm(managerListForm);            
        }

        // Loads the specified form into the main panel of the admin page form
        private void LoadForm(object form)
        {
            // Remove any existing form from the main panel
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            // Cast the specified form to a form object and add it to the main panel
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }

        // Logout button event handler that shows the home page form and hides the admin page form
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            homePageForm.Show();
            this.Hide();
        }

        // Manager list button event handler that loads the manager list form into the main panel
        private void ManagerListButton_Click(object sender, EventArgs e)
        {
            LoadForm(managerListForm);
        }

        // New manager entry button event handler that loads the new manager entry form into the main panel
        private void NewManagerEntryButton_Click(object sender, EventArgs e)
        {
            LoadForm(newManagerEntryForm);
        }

        // Manager delete button event handler that loads the manager delete form into the main panel
        private void ManagerDeleteButton_Click(object sender, EventArgs e)
        {
            LoadForm(managerDeleteForm);
        }
    }
}
