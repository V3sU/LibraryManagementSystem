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
    // Home page form that provides login options for administrators and managers
    public partial class HomePageForm : Form
    {
        private AdminLoginForm adminLoginForm;
        private ManagerLoginForm managerLoginForm;

        public HomePageForm()
        {
            // Initialize the form and load the admin login form by default
            adminLoginForm = new AdminLoginForm(this);
            managerLoginForm = new ManagerLoginForm(this);
            InitializeComponent();
            LoadForm(adminLoginForm);
        }

        // Loads the specified form into the main panel of the home page form
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

        // Admin login button event handler that loads the admin login form into the main panel
        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            LoadForm(adminLoginForm);
        }

        // Manager login button event handler that loads the manager login form into the main panel
        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {
            LoadForm(managerLoginForm);
        }

        // Exit button event handler that terminates the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
