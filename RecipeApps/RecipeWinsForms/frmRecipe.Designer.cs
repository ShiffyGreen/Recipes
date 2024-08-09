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
            lblCurrentStatis = new Label();
            lblCalories = new Label();
            txtCalorieCount = new TextBox();
            lblCuisine = new Label();
            txtCuisine = new ComboBox();
            txtUser = new ComboBox();
            lbluser = new Label();
            btnDelete = new Button();
            lblStatusDates = new Label();
            txtCurrentStatus = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDateArchived = new Label();
            lblDatePublished = new Label();
            lblDateDrafted = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngrediants = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            tblmain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngrediants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 4;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2531643F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2658234F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.82633F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.913166F));
            tblmain.Controls.Add(lblRecipeN, 0, 1);
            tblmain.Controls.Add(txtRecipeName, 1, 1);
            tblmain.Controls.Add(btnSave, 0, 0);
            tblmain.Controls.Add(lblCurrentStatis, 0, 5);
            tblmain.Controls.Add(lblCalories, 0, 2);
            tblmain.Controls.Add(txtCalorieCount, 1, 2);
            tblmain.Controls.Add(lblCuisine, 0, 3);
            tblmain.Controls.Add(txtCuisine, 1, 3);
            tblmain.Controls.Add(txtUser, 1, 4);
            tblmain.Controls.Add(lbluser, 0, 4);
            tblmain.Controls.Add(btnDelete, 1, 0);
            tblmain.Controls.Add(lblStatusDates, 0, 7);
            tblmain.Controls.Add(txtCurrentStatus, 1, 5);
            tblmain.Controls.Add(tblStatusDates, 1, 6);
            tblmain.Controls.Add(tbChildRecords, 0, 10);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 11;
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.Size = new Size(714, 593);
            tblmain.TabIndex = 0;
            // 
            // lblRecipeN
            // 
            lblRecipeN.Anchor = AnchorStyles.Left;
            lblRecipeN.AutoSize = true;
            lblRecipeN.Location = new Point(3, 54);
            lblRecipeN.Name = "lblRecipeN";
            lblRecipeN.Size = new Size(98, 20);
            lblRecipeN.TabIndex = 0;
            lblRecipeN.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            tblmain.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Location = new Point(218, 43);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(450, 42);
            txtRecipeName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCurrentStatis
            // 
            lblCurrentStatis.Anchor = AnchorStyles.Left;
            lblCurrentStatis.AutoSize = true;
            lblCurrentStatis.Location = new Point(3, 211);
            lblCurrentStatis.Name = "lblCurrentStatis";
            lblCurrentStatis.Size = new Size(101, 20);
            lblCurrentStatis.TabIndex = 8;
            lblCurrentStatis.Text = "Current Status";
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Left;
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 100);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(62, 20);
            lblCalories.TabIndex = 2;
            lblCalories.Text = "Calories";
            // 
            // txtCalorieCount
            // 
            tblmain.SetColumnSpan(txtCalorieCount, 3);
            txtCalorieCount.Location = new Point(218, 91);
            txtCalorieCount.Multiline = true;
            txtCalorieCount.Name = "txtCalorieCount";
            txtCalorieCount.Size = new Size(450, 39);
            txtCalorieCount.TabIndex = 3;
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 140);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(56, 20);
            lblCuisine.TabIndex = 4;
            lblCuisine.Text = "Cuisine";
            // 
            // txtCuisine
            // 
            tblmain.SetColumnSpan(txtCuisine, 3);
            txtCuisine.FormattingEnabled = true;
            txtCuisine.Location = new Point(218, 136);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(450, 28);
            txtCuisine.TabIndex = 5;
            // 
            // txtUser
            // 
            tblmain.SetColumnSpan(txtUser, 3);
            txtUser.FormattingEnabled = true;
            txtUser.Location = new Point(218, 170);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(450, 28);
            txtUser.TabIndex = 7;
            // 
            // lbluser
            // 
            lbluser.Anchor = AnchorStyles.Left;
            lbluser.AutoSize = true;
            lbluser.Location = new Point(3, 174);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(38, 20);
            lbluser.TabIndex = 6;
            lbluser.Text = "User";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(218, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 281);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(91, 20);
            lblStatusDates.TabIndex = 11;
            lblStatusDates.Text = "Status Dates";
            // 
            // txtCurrentStatus
            // 
            tblmain.SetColumnSpan(txtCurrentStatus, 3);
            txtCurrentStatus.Location = new Point(218, 201);
            txtCurrentStatus.Margin = new Padding(3, 0, 3, 10);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(371, 30);
            txtCurrentStatus.TabIndex = 9;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblmain.SetColumnSpan(tblStatusDates, 3);
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDateArchived, 2, 0);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(txtDateDrafted, 0, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 1, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 2, 1);
            tblStatusDates.Location = new Point(218, 244);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblmain.SetRowSpan(tblStatusDates, 2);
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(450, 54);
            tblStatusDates.TabIndex = 10;
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(301, 3);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(146, 20);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "Archived";
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(152, 3);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(143, 20);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Published";
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(3, 3);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(143, 20);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Drafted ";
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(3, 30);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(143, 21);
            txtDateDrafted.TabIndex = 3;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(152, 30);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(143, 21);
            txtDatePublished.TabIndex = 4;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(301, 30);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(146, 21);
            txtDateArchived.TabIndex = 5;
            // 
            // tbChildRecords
            // 
            tblmain.SetColumnSpan(tbChildRecords, 4);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 304);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(708, 286);
            tbChildRecords.TabIndex = 15;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngrediants);
            tbIngredients.Location = new Point(4, 29);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(700, 253);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngrediants
            // 
            tblIngrediants.ColumnCount = 1;
            tblIngrediants.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngrediants.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngrediants.Controls.Add(gIngredients, 0, 1);
            tblIngrediants.Dock = DockStyle.Fill;
            tblIngrediants.Location = new Point(3, 3);
            tblIngrediants.Name = "tblIngrediants";
            tblIngrediants.RowCount = 2;
            tblIngrediants.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5748987F));
            tblIngrediants.RowStyles.Add(new RowStyle(SizeType.Percent, 85.4251F));
            tblIngrediants.Size = new Size(694, 247);
            tblIngrediants.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(94, 29);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 39);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(688, 205);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 29);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(700, 253);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3603239F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 86.63968F));
            tblSteps.Size = new Size(694, 247);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(94, 27);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 36);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(688, 208);
            gSteps.TabIndex = 1;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 593);
            Controls.Add(tblmain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblmain.ResumeLayout(false);
            tblmain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngrediants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
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
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCalorieCount;
        private TextBox txtRecipeName;
        private Label txtCurrentStatus;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCuisine;
        private ComboBox txtCuisine;
        private ComboBox txtUser;
        private Label lbluser;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TableLayoutPanel tblIngrediants;
        private TabPage tbSteps;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}