namespace LibraryManagementSystem.forms
{
    partial class NewManagerEntr
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
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryIdManager = new System.Windows.Forms.TextBox();
            this.EntryPassBoxManager = new System.Windows.Forms.TextBox();
            this.ERRORLABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "AdminPage: Manager New Entry";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.createButton.Location = new System.Drawing.Point(188, 246);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(242, 28);
            this.createButton.TabIndex = 19;
            this.createButton.Text = "create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Manager id";
            // 
            // EntryIdManager
            // 
            this.EntryIdManager.Location = new System.Drawing.Point(278, 171);
            this.EntryIdManager.Name = "EntryIdManager";
            this.EntryIdManager.Size = new System.Drawing.Size(164, 20);
            this.EntryIdManager.TabIndex = 16;
            // 
            // EntryPassBoxManager
            // 
            this.EntryPassBoxManager.Location = new System.Drawing.Point(278, 201);
            this.EntryPassBoxManager.Name = "EntryPassBoxManager";
            this.EntryPassBoxManager.PasswordChar = 'x';
            this.EntryPassBoxManager.Size = new System.Drawing.Size(164, 20);
            this.EntryPassBoxManager.TabIndex = 15;
            // 
            // ERRORLABEL
            // 
            this.ERRORLABEL.AutoSize = true;
            this.ERRORLABEL.BackColor = System.Drawing.Color.IndianRed;
            this.ERRORLABEL.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRORLABEL.Location = new System.Drawing.Point(185, 306);
            this.ERRORLABEL.Name = "ERRORLABEL";
            this.ERRORLABEL.Size = new System.Drawing.Size(0, 17);
            this.ERRORLABEL.TabIndex = 20;
            // 
            // NewManagerEntr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.ERRORLABEL);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntryIdManager);
            this.Controls.Add(this.EntryPassBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewManagerEntr";
            this.Text = "NewManagerEntr";
            this.Load += new System.EventHandler(this.NewManagerEntr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EntryIdManager;
        private System.Windows.Forms.TextBox EntryPassBoxManager;
        private System.Windows.Forms.Label ERRORLABEL;
    }
}