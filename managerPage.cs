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
    public partial class ManagerPageForm : Form
    {
        private readonly HomePage _homePage;
        
        private readonly NewBookEntry _newBookEntryForm = new NewBookEntry();
        private readonly UpdateBookStockForm _updateBookStockForm = new UpdateBookStockForm();
        private readonly SearchBookForm _searchBookForm = new SearchBookForm();
        private readonly DeleteBookStockForm _deleteBookStockForm = new DeleteBookStockForm();
        private readonly BookStockListForm _bookStockListForm = new BookStockListForm();

        public ManagerPageForm(HomePage homePage)
        {
            _homePage = homePage;   
            InitializeComponent();
            LoadForm(_newBookEntryForm);
        }

        // Loads the specified form into the main panel.
        public void LoadForm(object form)
        {
            if (mainPanelManagerPage.Controls.Count > 0)
            {
                mainPanelManagerPage.Controls.RemoveAt(0);
            }
            Form loadedForm = form as Form;
            loadedForm.TopLevel = false;
            loadedForm.Dock = DockStyle.Fill;
            mainPanelManagerPage.Controls.Add(loadedForm);
            mainPanelManagerPage.Tag = loadedForm;
            loadedForm.Show();
        }

        private void ManagerPageForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Logs out the user and returns to the home page.
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _homePage.Show();
            Hide();  
        }

        // Loads specific forms based on button clicks.
        private void NewBookEntryButton_Click(object sender, EventArgs e)
        {
            LoadForm(_newBookEntryForm);
        }

        private void UpdateBookStockButton_Click(object sender, EventArgs e)
        {
            LoadForm(_updateBookStockForm);
        }

        private void SearchBookButton_Click(object sender, EventArgs e)
        {
            LoadForm(_searchBookForm);
        }

        private void DeleteBookStockButton_Click(object sender, EventArgs e)
        {
            LoadForm(_deleteBookStockForm);
        }

        private void BookStockListButton_Click(object sender, EventArgs e)
        {
            LoadForm(_bookStockListForm);
        }
    }
}
