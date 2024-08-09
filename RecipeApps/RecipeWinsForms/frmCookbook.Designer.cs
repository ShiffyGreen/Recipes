namespace RecipeWinsForms
{
    partial class frmCookbook
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
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtCookbookName = new TextBox();
            txtUser = new ComboBox();
            lblDateCreate = new Label();
            lblDateCreated = new Label();
            txtPrice = new TextBox();
            ckActive = new CheckBox();
            tblRecipe = new TableLayoutPanel();
            btnRecipeSave = new Button();
            grecipe = new DataGridView();
            tblMain.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.862175F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.137825F));
            tblMain.Controls.Add(btnSave, 1, 0);
            tblMain.Controls.Add(btnDelete, 2, 0);
            tblMain.Controls.Add(lblCookbookName, 1, 1);
            tblMain.Controls.Add(lblUser, 1, 2);
            tblMain.Controls.Add(lblPrice, 1, 4);
            tblMain.Controls.Add(lblActive, 1, 5);
            tblMain.Controls.Add(txtCookbookName, 2, 1);
            tblMain.Controls.Add(txtUser, 2, 2);
            tblMain.Controls.Add(lblDateCreate, 3, 3);
            tblMain.Controls.Add(lblDateCreated, 3, 4);
            tblMain.Controls.Add(txtPrice, 2, 4);
            tblMain.Controls.Add(ckActive, 2, 5);
            tblMain.Controls.Add(tblRecipe, 0, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 89.1719742F));
            tblMain.Size = new Size(800, 641);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(23, 10);
            btnSave.Margin = new Padding(3, 10, 3, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 10);
            btnDelete.Margin = new Padding(3, 10, 3, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(23, 59);
            lblCookbookName.Margin = new Padding(3, 10, 3, 10);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(121, 20);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(23, 99);
            lblUser.Margin = new Padding(3, 10, 3, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 170);
            lblPrice.Margin = new Padding(3, 0, 3, 10);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(23, 202);
            lblActive.Margin = new Padding(3, 0, 3, 10);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(50, 20);
            lblActive.TabIndex = 5;
            lblActive.Text = "Active";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Location = new Point(150, 55);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(364, 27);
            txtCookbookName.TabIndex = 6;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Left;
            tblMain.SetColumnSpan(txtUser, 2);
            txtUser.FormattingEnabled = true;
            txtUser.Location = new Point(150, 95);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(364, 28);
            txtUser.TabIndex = 7;
            // 
            // lblDateCreate
            // 
            lblDateCreate.AutoSize = true;
            lblDateCreate.Location = new Point(345, 139);
            lblDateCreate.Margin = new Padding(3, 10, 3, 10);
            lblDateCreate.Name = "lblDateCreate";
            lblDateCreate.Size = new Size(100, 20);
            lblDateCreate.TabIndex = 8;
            lblDateCreate.Text = "Date Created:";
            // 
            // lblDateCreated
            // 
            lblDateCreated.Location = new Point(345, 169);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(169, 30);
            lblDateCreated.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 172);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 10;
            // 
            // ckActive
            // 
            ckActive.Anchor = AnchorStyles.Left;
            ckActive.AutoSize = true;
            ckActive.Location = new Point(150, 208);
            ckActive.Name = "ckActive";
            ckActive.Size = new Size(18, 17);
            ckActive.TabIndex = 11;
            ckActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipe, 4);
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.Controls.Add(btnRecipeSave, 0, 0);
            tblRecipe.Controls.Add(grecipe, 0, 1);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 235);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle());
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 89.73684F));
            tblRecipe.Size = new Size(794, 403);
            tblRecipe.TabIndex = 12;
            // 
            // btnRecipeSave
            // 
            btnRecipeSave.Location = new Point(3, 10);
            btnRecipeSave.Margin = new Padding(3, 10, 3, 10);
            btnRecipeSave.Name = "btnRecipeSave";
            btnRecipeSave.Size = new Size(94, 29);
            btnRecipeSave.TabIndex = 0;
            btnRecipeSave.Text = "Save";
            btnRecipeSave.UseVisualStyleBackColor = true;
            // 
            // grecipe
            // 
            grecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grecipe.Dock = DockStyle.Fill;
            grecipe.Location = new Point(3, 52);
            grecipe.Name = "grecipe";
            grecipe.RowHeadersWidth = 51;
            grecipe.RowTemplate.Height = 29;
            grecipe.Size = new Size(788, 348);
            grecipe.TabIndex = 1;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(tblMain);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox txtUser;
        private Label lblDateCreate;
        private Label lblDateCreated;
        private TextBox txtPrice;
        private CheckBox ckActive;
        private TableLayoutPanel tblRecipe;
        private Button btnRecipeSave;
        private DataGridView grecipe;
    }
}