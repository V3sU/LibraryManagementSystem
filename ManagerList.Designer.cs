namespace LibraryManagementSystem.forms
{
    partial class ManagerListForm
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
        this.managersDataGridView = new System.Windows.Forms.DataGridView();
        this.refreshButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).BeginInit();
        this.SuspendLayout();
        // 
        // titleLabel
        // 
        this.titleLabel.AutoSize = true;
        this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.titleLabel.Location = new System.Drawing.Point(195, 51);
        this.titleLabel.Name = "titleLabel";
        this.titleLabel.Size = new System.Drawing.Size(245, 27);
        this.titleLabel.TabIndex = 1;
        this.titleLabel.Text = "AdminPage: Manager's List";
        this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
        // 
        // managersDataGridView
        // 
        this.managersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.managersDataGridView.Location = new System.Drawing.Point(34, 94);
        this.managersDataGridView.Name = "managersDataGridView";
        this.managersDataGridView.Size = new System.Drawing.Size(571, 227);
        this.managersDataGridView.TabIndex = 3;
        // 
        // refreshButton
        // 
        this.refreshButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.refreshButton.Location = new System.Drawing.Point(34, 337);
        this.refreshButton.Name = "refreshButton";
        this.refreshButton.Size = new System.Drawing.Size(80, 27);
        this.refreshButton.TabIndex = 4;
        this.refreshButton.Text = "Refresh";
        this.refreshButton.UseVisualStyleBackColor = true;
        this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
        // 
        // ManagerListForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(638, 450);
        this.Controls.Add(this.refreshButton);
        this.Controls.Add(this.managersDataGridView);
        this.Controls.Add(this.titleLabel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "ManagerListForm";
        this.Text = "ManagerListForm";
        this.Load += new System.EventHandler(this.ManagerListForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.DataGridView managersDataGridView;
    private System.Windows.Forms.Button refreshButton;
}
