using System;

namespace LibraryManagementSystem.Forms
{
    partial class NewManagerEntryForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.managerIdLabel = new System.Windows.Forms.Label();
            this.managerIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(183, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(292, 27);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Admin Page: New Manager Entry";

            // createButton
            this.createButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.createButton.Location = new System.Drawing.Point(188, 246);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(242, 28);
            this.createButton.TabIndex = 19;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.OnCreateButtonClick);

            // passwordLabel
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(185, 203);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 17);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";

            // managerIdLabel
            this.managerIdLabel.AutoSize = true;
            this.managerIdLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerIdLabel.Location = new System.Drawing.Point(185, 174);
            this.managerIdLabel.Name = "managerIdLabel";
            this.managerIdLabel.Size = new System.Drawing.Size(76, 17);
            this.managerIdLabel.TabIndex = 17;
            this.managerIdLabel.Text = "Manager ID";

            // managerIdTextBox
            this.managerIdTextBox.Location = new System.Drawing.Point(278, 171);
            this.managerIdTextBox.Name = "managerIdTextBox";
            this.managerIdTextBox.Size = new System.Drawing.Size(164, 20);
            this.managerIdTextBox.TabIndex = 16;
            
            // passwordTextBox
            this.passwordTextBox.Location = new System.Drawing.Point(278, 201);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = 'x';
            this.passwordTextBox.Size = new System.Drawing.Size(164, 20);
            this.passwordTextBox.TabIndex = 15;

            // errorLabel
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(185, 306);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 20;

            // NewManagerEntryForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.managerIdLabel);
            this.Controls.Add(this.managerIdTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewManagerEntryForm";
            this.Text = "NewManagerEntryForm";
            this.Load += new System.EventHandler(this.OnNewManagerEntryFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label managerIdLabel;
        private System.Windows.Forms.TextBox managerIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
