namespace LibraryManagementSystem.forms
{
    partial class ManagerDeletionForm
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
            this.deleteManagerButton = new System.Windows.Forms.Button();
            this.managerIdLabel = new System.Windows.Forms.Label();
            this.managerIdTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteManagerButton
            // 
            this.deleteManagerButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteManagerButton.Location = new System.Drawing.Point(188, 246);
            this.deleteManagerButton.Name = "deleteManagerButton";
            this.deleteManagerButton.Size = new System.Drawing.Size(242, 28);
            this.deleteManagerButton.TabIndex = 25;
            this.deleteManagerButton.Text = "Delete User";
            this.deleteManagerButton.UseVisualStyleBackColor = true;
            this.deleteManagerButton.Click += new System.EventHandler(this.DeleteManagerButton_Click);
            // 
            // managerIdLabel
            // 
            this.managerIdLabel.AutoSize = true;
            this.managerIdLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerIdLabel.Location = new System.Drawing.Point(185, 196);
            this.managerIdLabel.Name = "managerIdLabel";
            this.managerIdLabel.Size = new System.Drawing.Size(76, 17);
            this.managerIdLabel.TabIndex = 23;
            this.managerIdLabel.Text = "Manager ID";
            // 
            // managerIdTextBox
            // 
            this.managerIdTextBox.Location = new System.Drawing.Point(278, 193);
            this.managerIdTextBox.Name = "managerIdTextBox";
            this.managerIdTextBox.Size = new System.Drawing.Size(164, 20);
            this.managerIdTextBox.TabIndex = 22;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(183, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(276, 27);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Admin Page: Delete a Manager";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(196, 304);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 26;
            //
            // ManagerDeletionForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.deleteManagerButton);
            this.Controls.Add(this.managerIdLabel);
            this.Controls.Add(this.managerIdTextBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerDeletionForm";
            this.Text = "ManagerDeletionForm";
            this.Load += new System.EventHandler(this.ManagerDeletionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            
            }

        #endregion

        private System.Windows.Forms.Button deleteManagerButton;
        private System.Windows.Forms.Label managerIdLabel;
        private System.Windows.Forms.TextBox managerIdTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label errorLabel;
        
    }
}
