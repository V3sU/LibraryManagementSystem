namespace LibraryManagementSystem.forms
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminLoginInfo = new System.Windows.Forms.Label();
            this.idBoxAdmin = new System.Windows.Forms.TextBox();
            this.passBoxAdmin = new System.Windows.Forms.TextBox();
            this.errorAdminLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(197, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User id";
            // 
            // adminLoginInfo
            // 
            this.adminLoginInfo.AutoSize = true;
            this.adminLoginInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.adminLoginInfo.Location = new System.Drawing.Point(194, 211);
            this.adminLoginInfo.Name = "adminLoginInfo";
            this.adminLoginInfo.Size = new System.Drawing.Size(196, 15);
            this.adminLoginInfo.TabIndex = 10;
            this.adminLoginInfo.Text = "please login if you are an ADMIN";
            // 
            // idBoxAdmin
            // 
            this.idBoxAdmin.Location = new System.Drawing.Point(263, 246);
            this.idBoxAdmin.Name = "idBoxAdmin";
            this.idBoxAdmin.Size = new System.Drawing.Size(164, 20);
            this.idBoxAdmin.TabIndex = 9;
            // 
            // passBoxAdmin
            // 
            this.passBoxAdmin.Location = new System.Drawing.Point(263, 272);
            this.passBoxAdmin.Name = "passBoxAdmin";
            this.passBoxAdmin.PasswordChar = 'x';
            this.passBoxAdmin.Size = new System.Drawing.Size(164, 20);
            this.passBoxAdmin.TabIndex = 8;
            this.passBoxAdmin.TextChanged += new System.EventHandler(this.passBoxAdmin_TextChanged);
            // 
            // errorAdminLogin
            // 
            this.errorAdminLogin.AutoSize = true;
            this.errorAdminLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.errorAdminLogin.Location = new System.Drawing.Point(481, 246);
            this.errorAdminLogin.Name = "errorAdminLogin";
            this.errorAdminLogin.Size = new System.Drawing.Size(0, 13);
            this.errorAdminLogin.TabIndex = 15;
            this.errorAdminLogin.Click += new System.EventHandler(this.errorAdminLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorAdminLogin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminLoginInfo);
            this.Controls.Add(this.idBoxAdmin);
            this.Controls.Add(this.passBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "HomePageAdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label adminLoginInfo;
        private System.Windows.Forms.TextBox idBoxAdmin;
        private System.Windows.Forms.TextBox passBoxAdmin;
        private System.Windows.Forms.Label errorAdminLogin;
    }
}