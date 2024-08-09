namespace RecipeWinsForms
{
    partial class frmDashboard
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
            lblHeader = new Label();
            lblDesc = new Label();
            gData = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblmain
            // 
            tblmain.ColumnCount = 3;
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblmain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblmain.Controls.Add(lblHeader, 1, 0);
            tblmain.Controls.Add(lblDesc, 1, 1);
            tblmain.Controls.Add(gData, 1, 2);
            tblmain.Controls.Add(tblButtons, 1, 3);
            tblmain.Dock = DockStyle.Fill;
            tblmain.Location = new Point(0, 0);
            tblmain.Name = "tblmain";
            tblmain.RowCount = 5;
            tblmain.RowStyles.Add(new RowStyle());
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3668346F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 58.2236824F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4210529F));
            tblmain.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tblmain.Size = new Size(800, 450);
            tblmain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(246, 20);
            lblHeader.Margin = new Padding(3, 20, 3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(308, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(153, 82);
            lblDesc.Margin = new Padding(3, 30, 3, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(470, 41);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. you can also...";
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(153, 126);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(494, 171);
            gData.TabIndex = 2;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(153, 303);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(494, 50);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(3, 20);
            btnRecipeList.Margin = new Padding(3, 20, 3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(158, 27);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(167, 20);
            btnMealList.Margin = new Padding(3, 20, 3, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(158, 27);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(331, 20);
            btnCookbookList.Margin = new Padding(3, 20, 3, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(160, 27);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblmain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblmain.ResumeLayout(false);
            tblmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblmain;
        private Label lblHeader;
        private Label lblDesc;
        private DataGridView gData;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}