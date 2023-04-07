namespace LibraryManagementSystem.forms
{
    partial class NewBookEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.writerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookPublishYearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.ERRORLAvEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "ManagerPage: New book entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Book Name";
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(162, 123);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookTextBox.TabIndex = 24;
            this.bookTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Writer Name";
            // 
            // writerNameTextBox
            // 
            this.writerNameTextBox.Location = new System.Drawing.Point(162, 220);
            this.writerNameTextBox.Name = "writerNameTextBox";
            this.writerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.writerNameTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Catagory Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // entryDateTimePicker
            // 
            this.entryDateTimePicker.Location = new System.Drawing.Point(162, 269);
            this.entryDateTimePicker.Name = "entryDateTimePicker";
            this.entryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.entryDateTimePicker.TabIndex = 29;
            this.entryDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bookPublishYearComboBox
            // 
            this.bookPublishYearComboBox.FormattingEnabled = true;
            this.bookPublishYearComboBox.Items.AddRange(new object[] {
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
            this.bookPublishYearComboBox.Location = new System.Drawing.Point(162, 169);
            this.bookPublishYearComboBox.Name = "bookPublishYearComboBox";
            this.bookPublishYearComboBox.Size = new System.Drawing.Size(200, 21);
            this.bookPublishYearComboBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Entry date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(162, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(480, 172);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(135, 20);
            this.quantityTextBox.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Book publish year";
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
            this.categoryComboBox.Location = new System.Drawing.Point(480, 119);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(135, 21);
            this.categoryComboBox.TabIndex = 50;
            // 
            // ERRORLAvEL
            // 
            this.ERRORLAvEL.AutoSize = true;
            this.ERRORLAvEL.BackColor = System.Drawing.Color.Red;
            this.ERRORLAvEL.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRORLAvEL.ForeColor = System.Drawing.Color.Black;
            this.ERRORLAvEL.Location = new System.Drawing.Point(12, 350);
            this.ERRORLAvEL.Name = "ERRORLAvEL";
            this.ERRORLAvEL.Size = new System.Drawing.Size(0, 17);
            this.ERRORLAvEL.TabIndex = 51;
            // 
            // NewBookEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.ERRORLAvEL);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookPublishYearComboBox);
            this.Controls.Add(this.entryDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.writerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewBookEntry";
            this.Text = "NewBookEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox writerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker entryDateTimePicker;
        private System.Windows.Forms.ComboBox bookPublishYearComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label ERRORLAvEL;
    }
}