using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    partial class NewBookEntryForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.WriterNameLabel = new System.Windows.Forms.Label();
            this.WriterNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.EntryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PublishYearComboBox = new System.Windows.Forms.ComboBox();
            this.EntryDateLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PublishYearLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(192, 40);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(267, 27);
            this.TitleLabel.TabIndex = 21;
            this.TitleLabel.Text = "Manager Page: New Book Entry";

            // BookNameLabel
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameLabel.Location = new System.Drawing.Point(71, 123);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(72, 17);
            this.BookNameLabel.TabIndex = 25;
            this.BookNameLabel.Text = "Book Name";

            // BookNameTextBox
            this.BookNameTextBox.Location = new System.Drawing.Point(162, 123);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.BookNameTextBox.TabIndex = 24;
            this.BookNameTextBox.TextChanged += new System.EventHandler(this.BookNameTextBox_TextChanged);

            // WriterNameLabel
            this.WriterNameLabel.AutoSize = true;
            this.WriterNameLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterNameLabel.Location = new System.Drawing.Point(59, 220);
            this.WriterNameLabel.Name = "WriterNameLabel";
            this.WriterNameLabel.Size = new System.Drawing.Size(84, 17);
            this.WriterNameLabel.TabIndex = 27;
            this.WriterNameLabel.Text = "Writer Name";

            // WriterNameTextBox
            this.WriterNameTextBox.Location = new System.Drawing.Point(162, 220);
            this.WriterNameTextBox.Name = "WriterNameTextBox";
            this.WriterNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.WriterNameTextBox.TabIndex = 26;
            
            // CategoryLabel
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(373, 121);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(95, 17);
            this.CategoryLabel.TabIndex = 28;
            this.CategoryLabel.Text = "Category Name";

            // EntryDatePicker
            this.EntryDatePicker.Location = new System.Drawing.Point(162, 269);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EntryDatePicker.TabIndex = 29;
            this.EntryDatePicker.ValueChanged += new System.EventHandler(this.EntryDatePicker_ValueChanged);

            // PublishYearComboBox
            this.PublishYearComboBox.FormattingEnabled = true;
            this.PublishYearComboBox.Items.AddRange(new object[] {
            "1999",
            "2001",
            "2003",
            "2005",
            "2007",
            "2009",
            "2011",
            "2013",
            "2015",
            "2017",
            "2019",
            "2021"});
            this.PublishYearComboBox.Location = new System.Drawing.Point(162, 169);
            this.PublishYearComboBox.Name = "PublishYearComboBox";
            this.PublishYearComboBox.Size = new System.Drawing.Size(200, 21);
            this.PublishYearComboBox.TabIndex = 32;

            // EntryDateLabel
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryDateLabel.Location = new System.Drawing.Point(71, 269);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(72, 17);
            this.EntryDateLabel.TabIndex = 28;
            this.EntryDateLabel.Text = "Entry Date";

            // InsertButton
            this.InsertButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.InsertButton.Location = new System.Drawing.Point(162, 315);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(148, 23);
            this.InsertButton.TabIndex = 45;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);

            // QuantityLabel
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(406, 172);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(62, 17);
            this.QuantityLabel.TabIndex = 48;
            this.QuantityLabel.Text = "Quantity";

            // QuantityTextBox
            this.QuantityTextBox.Location = new System.Drawing.Point(480, 172);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(135, 20);
            this.QuantityTextBox.TabIndex = 47;

            // PublishYearLabel
            this.PublishYearLabel.AutoSize = true;
            this.PublishYearLabel.Font = new System.Drawing
            .Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearLabel.Location = new System.Drawing.Point(71, 169);
            this.PublishYearLabel.Name = "PublishYearLabel";
            this.PublishYearLabel.Size = new System.Drawing.Size(85, 17);
            this.PublishYearLabel.TabIndex = 49;
            this.PublishYearLabel.Text = "Publish Year";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PublishYearLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.EntryDateLabel);
            this.Controls.Add(this.PublishYearComboBox);
            this.Controls.Add(this.EntryDatePicker);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.LibraryGridView);
            this.Name = "MainForm";
            this.Text = "Library Management System";
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
