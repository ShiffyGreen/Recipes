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
            lblRecipeName = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblCalories = new Label();
            lblCurrentStatis = new Label();
            lblRecipePicture = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblRecipe = new Label();
            txtCalories = new TextBox();
            txtCurrentStatus = new TextBox();
            txtRecipePicture = new TextBox();
            tblmain.SuspendLayout();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 2;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblmain.Controls.Add(lblRecipeName, 0, 0);
            tblmain.Controls.Add(lblDateDrafted, 0, 1);
            tblmain.Controls.Add(lblDatePublished, 0, 2);
            tblmain.Controls.Add(lblDateArchived, 0, 3);
            tblmain.Controls.Add(lblCalories, 0, 4);
            tblmain.Controls.Add(lblCurrentStatis, 0, 5);
            tblmain.Controls.Add(lblRecipePicture, 0, 6);
            tblmain.Controls.Add(txtDateDrafted, 1, 1);
            tblmain.Controls.Add(txtDatePublished, 1, 2);
            tblmain.Controls.Add(txtDateArchived, 1, 3);
            tblmain.Controls.Add(lblRecipe, 1, 0);
            tblmain.Controls.Add(txtCalories, 1, 4);
            tblmain.Controls.Add(txtCurrentStatus, 1, 5);
            tblmain.Controls.Add(txtRecipePicture, 1, 6);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 7;
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblmain.Size = new Size(609, 453);
            tblmain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(98, 20);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 64);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(100, 20);
            lblDateDrafted.TabIndex = 1;
            lblDateDrafted.Text = "Date Drafted ";
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 128);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(109, 20);
            lblDatePublished.TabIndex = 2;
            lblDatePublished.Text = "Date Published";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 192);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(103, 20);
            lblDateArchived.TabIndex = 3;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 256);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 4;
            lblCalories.Text = "Calories";
            // 
            // lblCurrentStatis
            // 
            lblCurrentStatis.AutoSize = true;
            lblCurrentStatis.Location = new Point(3, 320);
            lblCurrentStatis.Name = "lblCurrentStatis";
            lblCurrentStatis.Size = new Size(97, 20);
            lblCurrentStatis.TabIndex = 5;
            lblCurrentStatis.Text = "Current Statis";
            // 
            // lblRecipePicture
            // 
            lblRecipePicture.AutoSize = true;
            lblRecipePicture.Location = new Point(3, 384);
            lblRecipePicture.Name = "lblRecipePicture";
            lblRecipePicture.Size = new Size(103, 20);
            lblRecipePicture.TabIndex = 6;
            lblRecipePicture.Text = "Recipe Picture";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(307, 67);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(299, 58);
            txtDateDrafted.TabIndex = 8;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(307, 131);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(299, 58);
            txtDatePublished.TabIndex = 9;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(307, 195);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(299, 58);
            txtDateArchived.TabIndex = 10;
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.Dock = DockStyle.Fill;
            lblRecipe.Location = new Point(307, 0);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(299, 64);
            lblRecipe.TabIndex = 11;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(307, 259);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(299, 58);
            txtCalories.TabIndex = 12;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Dock = DockStyle.Fill;
            txtCurrentStatus.Location = new Point(307, 323);
            txtCurrentStatus.Multiline = true;
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(299, 58);
            txtCurrentStatus.TabIndex = 13;
            // 
            // txtRecipePicture
            // 
            txtRecipePicture.Dock = DockStyle.Fill;
            txtRecipePicture.Location = new Point(307, 387);
            txtRecipePicture.Multiline = true;
            txtRecipePicture.Name = "txtRecipePicture";
            txtRecipePicture.Size = new Size(299, 63);
            txtRecipePicture.TabIndex = 14;
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
        private Label lblRecipeName;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblCalories;
        private Label lblCurrentStatis;
        private Label lblRecipePicture;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblRecipe;
        private TextBox txtCalories;
        private TextBox txtCurrentStatus;
        private TextBox txtRecipePicture;
    }
}