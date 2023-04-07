namespace LibraryManagementSystem.forms
{
    partial class ManagerDelete
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
            this.DeleteManagerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteIdBoxManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ERRORLABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteManagerButton
            // 
            this.DeleteManagerButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteManagerButton.Location = new System.Drawing.Point(188, 246);
            this.DeleteManagerButton.Name = "DeleteManagerButton";
            this.DeleteManagerButton.Size = new System.Drawing.Size(242, 28);
            this.DeleteManagerButton.TabIndex = 25;
            this.DeleteManagerButton.Text = "delete user";
            this.DeleteManagerButton.UseVisualStyleBackColor = true;
            this.DeleteManagerButton.Click += new System.EventHandler(this.DeleteManagerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manager id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeleteIdBoxManager
            // 
            this.DeleteIdBoxManager.Location = new System.Drawing.Point(278, 193);
            this.DeleteIdBoxManager.Name = "DeleteIdBoxManager";
            this.DeleteIdBoxManager.Size = new System.Drawing.Size(164, 20);
            this.DeleteIdBoxManager.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "AdminPage: Delete a manager ";
            // 
            // ERRORLABEL
            // 
            this.ERRORLABEL.AutoSize = true;
            this.ERRORLABEL.BackColor = System.Drawing.Color.IndianRed;
            this.ERRORLABEL.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRORLABEL.Location = new System.Drawing.Point(196, 304);
            this.ERRORLABEL.Name = "ERRORLABEL";
            this.ERRORLABEL.Size = new System.Drawing.Size(0, 17);
            this.ERRORLABEL.TabIndex = 26;
            // 
            // ManagerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.ERRORLABEL);
            this.Controls.Add(this.DeleteManagerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteIdBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerDelete";
            this.Text = "ManagerDelete";
            this.Load += new System.EventHandler(this.ManagerDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteManagerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeleteIdBoxManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ERRORLABEL;
    }
}