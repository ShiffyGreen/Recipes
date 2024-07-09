namespace RecipeWinsForms
{
    partial class frmRecipe
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
            tblmain = new TableLayoutPanel();
            lblRecipeN = new Label();
            txtRecipeName = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            lblRecipePicture = new Label();
            txtPictureName = new Label();
            lblDateArchived = new Label();
            txtDateArchived = new TextBox();
            lblDatePublished = new Label();
            txtDatePublished = new TextBox();
            lblCurrentStatis = new Label();
            txtCurrentStatus = new Label();
            lblDateDrafted = new Label();
            txtDateDrafted = new TextBox();
            lblCalories = new Label();
            txtCalorieCount = new TextBox();
            lblCuisine = new Label();
            txtCuisine = new ComboBox();
            txtUser = new ComboBox();
            lbluser = new Label();
            tblmain.SuspendLayout();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 2;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblmain.Controls.Add(lblRecipeN, 0, 1);
            tblmain.Controls.Add(txtRecipeName, 1, 1);
            tblmain.Controls.Add(btnSave, 0, 0);
            tblmain.Controls.Add(btnDelete, 1, 0);
            tblmain.Controls.Add(lblRecipePicture, 0, 9);
            tblmain.Controls.Add(txtPictureName, 1, 9);
            tblmain.Controls.Add(lblDateArchived, 0, 8);
            tblmain.Controls.Add(txtDateArchived, 1, 8);
            tblmain.Controls.Add(lblDatePublished, 0, 7);
            tblmain.Controls.Add(txtDatePublished, 1, 7);
            tblmain.Controls.Add(lblCurrentStatis, 0, 5);
            tblmain.Controls.Add(txtCurrentStatus, 1, 5);
            tblmain.Controls.Add(lblDateDrafted, 0, 6);
            tblmain.Controls.Add(txtDateDrafted, 1, 6);
            tblmain.Controls.Add(lblCalories, 0, 2);
            tblmain.Controls.Add(txtCalorieCount, 1, 2);
            tblmain.Controls.Add(lblCuisine, 0, 3);
            tblmain.Controls.Add(txtCuisine, 1, 3);
            tblmain.Controls.Add(txtUser, 1, 4);
            tblmain.Controls.Add(lbluser, 0, 4);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 10;
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.026753F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7967024F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0219736F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0223494F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0223494F));
            tblmain.Size = new Size(609, 453);
            tblmain.TabIndex = 0;
            // 
            // lblRecipeN
            // 
            lblRecipeN.AutoSize = true;
            lblRecipeN.Location = new Point(3, 40);
            lblRecipeN.Name = "lblRecipeN";
            lblRecipeN.Size = new Size(98, 20);
            lblRecipeN.TabIndex = 0;
            lblRecipeN.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(307, 43);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(299, 42);
            txtRecipeName.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(298, 34);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(307, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(299, 34);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.Location = new Point(3, 403);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(103, 20);
            lblRecipePicture.TabIndex = 6;
            lblRecipePicture.Text = "Recipe Picture";
            // 
            // txtPictureName
            // 
            txtPictureName.AutoSize = true;
            txtPictureName.Dock = DockStyle.Fill;
            txtPictureName.Location = new Point(307, 403);
            txtPictureName.Name = "txtPictureName";
            txtPictureName.Size = new Size(299, 50);
            txtPictureName.TabIndex = 16;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 358);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 3;
            lblDateArchived.Text = "Date Archived";
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(307, 361);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(299, 39);
            txtDateArchived.TabIndex = 10;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 313);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(109, 20);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.Text = "Date Published";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(307, 316);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(299, 39);
            txtDatePublished.TabIndex = 9;
            // 
            // lblCurrentStatis
            // 
            lblCurrentStatis.AutoSize = true;
            lblCurrentStatis.Location = new Point(3, 223);
            lblCurrentStatis.Name = "lblCurrentStatis";
            lblCurrentStatis.Size = new Size(101, 20);
            lblCurrentStatis.TabIndex = 5;
            lblCurrentStatis.Text = "Current Status";
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.AutoSize = true;
            txtCurrentStatus.Dock = DockStyle.Fill;
            txtCurrentStatus.Location = new Point(307, 223);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(299, 45);
            txtCurrentStatus.TabIndex = 17;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 268);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(100, 20);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.Text = "Date Drafted ";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Location = new Point(307, 271);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(299, 39);
            txtDateDrafted.TabIndex = 8;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 88);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 4;
            lblCalories.Text = "Calories";
            // 
            // txtCalorieCount
            // 
            txtCalorieCount.Location = new Point(307, 91);
            txtCalorieCount.Multiline = true;
            txtCalorieCount.Name = "txtCalorieCount";
            txtCalorieCount.Size = new Size(299, 39);
            txtCalorieCount.TabIndex = 12;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 133);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(56, 20);
            lblCuisine.TabIndex = 20;
            lblCuisine.Text = "Cuisine";
            // 
            // txtCuisine
            // 
            txtCuisine.FormattingEnabled = true;
            txtCuisine.Location = new Point(307, 136);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(227, 28);
            txtCuisine.TabIndex = 21;
            // 
            // txtUser
            // 
            txtUser.FormattingEnabled = true;
            txtUser.Location = new Point(307, 181);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(151, 28);
            txtUser.TabIndex = 22;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(3, 178);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(38, 20);
            lbluser.TabIndex = 23;
            lbluser.Text = "User";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 453);
            Controls.Add(tblmain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblmain.ResumeLayout(false);
            tblmain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblmain;
        private Label lblRecipeN;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblCalories;
        private Label lblCurrentStatis;
        private Label lblRecipePicture;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCalorieCount;
        private TextBox txtRecipeName;
        private Label txtPictureName;
        private Label txtCurrentStatus;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCuisine;
        private ComboBox txtCuisine;
        private ComboBox txtUser;
        private Label lbluser;
    }
}