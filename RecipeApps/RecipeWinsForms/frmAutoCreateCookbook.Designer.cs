namespace RecipeWinsForms
{
    partial class frmAutoCreateCookbook
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
            tblMain = new TableLayoutPanel();
            txtUsers = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.125F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.875F));
            tblMain.Controls.Add(txtUsers, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(40, 3, 3, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2222214F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75.77778F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // txtUsers
            // 
            txtUsers.Anchor = AnchorStyles.Right;
            txtUsers.FormattingEnabled = true;
            txtUsers.Location = new Point(106, 40);
            txtUsers.Margin = new Padding(3, 3, 40, 3);
            txtUsers.Name = "txtUsers";
            txtUsers.Size = new Size(207, 28);
            txtUsers.TabIndex = 1;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Location = new Point(393, 45);
            btnCreateCookbook.Margin = new Padding(40, 45, 0, 45);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(197, 19);
            btnCreateCookbook.TabIndex = 0;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmAutoCreateCookbook";
            Text = "Auto Create Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox txtUsers;
        private Button btnCreateCookbook;
    }
}