namespace LibraryManagementSystem.Forms
{
    partial class DeleteBookStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.errorDeleteBookLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.bookStockGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookStockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(192, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 27);
            this.titleLabel.TabIndex = 45;
            this.titleLabel.Text = "ManagerPage: Delete book stock";
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deleteBookButton.Location = new System.Drawing.Point(388, 319);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(167, 23);
            this.deleteBookButton.TabIndex = 68;
            this.deleteBookButton.Text = "DELETE BOOK";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLabel.Location = new System.Drawing.Point(56, 319);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(85, 20);
            this.bookNameLabel.TabIndex = 67;
            this.bookNameLabel.Text = "Book name";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Action and Adventure",
            "Classics",
            "Comic Book",
            "Detective and Mystery",
            "Fantasy",
            "Historical Fiction",
            "Horror",
            "Literary Fiction"});
            this.categoryComboBox.Location = new System.Drawing.Point(147, 82);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(190, 21);
            this.categoryComboBox.TabIndex = 66;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            //
            // categoryLabel
            //
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(71, 82);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(70, 20);
            this.categoryLabel.TabIndex = 65;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            //
            // bookNameTextBox
            //
            this.bookNameTextBox.Location = new System.Drawing.Point(147, 319);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookNameTextBox.TabIndex = 64;
            //
            // errorDeleteBookLabel
            //
            this.errorDeleteBookLabel.AutoSize = true;
            this.errorDeleteBookLabel.BackColor = System.Drawing.Color.Red;
            this.errorDeleteBookLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDeleteBookLabel.ForeColor = System.Drawing.Color.Black;
            this.errorDeleteBookLabel.Location = new System.Drawing.Point(57, 359);
            this.errorDeleteBookLabel.Name = "errorDeleteBookLabel";
            this.errorDeleteBookLabel.Size = new System.Drawing.Size(0, 17);
            this.errorDeleteBookLabel.TabIndex = 69;
            //
            // searchButton
            //
            this.searchButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.searchButton.Location = new System.Drawing.Point(388, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(167, 23);
            this.searchButton.TabIndex = 70;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            //
            // refreshButton
            //
            this.refreshButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(561, 115);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(31, 193);
            this.refreshButton.TabIndex = 72;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            //
            // bookStockGridView
            //
            this.bookStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookStockGridView.Location = new System.Drawing.Point(56, 115);
            this.bookStockGridView.Name = "bookStockGridView";
            this.bookStockGridView.Size = new System.Drawing.Size(499, 193);
            this.bookStockGridView.TabIndex = 71;
            this.bookStockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookStockGridView_CellContentClick);
            //
            // DeleteBookStock
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.bookStockGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.errorDeleteBookLabel);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.bookNameLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteBookStock";
            this.Text = "DeleteBookStock";
            ((System.ComponentModel.ISupportInitialize)(this.bookStockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            
            }

    #endregion
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Button deleteBookButton;
    private System.Windows.Forms.Label bookNameLabel;
    private System.Windows.Forms.ComboBox categoryComboBox;
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.TextBox bookNameTextBox;
    private System.Windows.Forms.Label errorDeleteBookLabel;
    private System.Windows.Forms.Button searchButton;
    private System.Windows.Forms.Button refreshButton;
    private System.Windows.Forms.DataGridView bookStockGridView;
}
