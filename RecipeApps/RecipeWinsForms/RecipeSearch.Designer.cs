namespace RecipeWinsForms
{
    partial class RecipeSearch
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            gRecipes = new DataGridView();
            btnNew = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5101166F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.892704F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6380539F));
            tblMain.Controls.Add(txtSearch, 0, 0);
            tblMain.Controls.Add(btnSearch, 1, 0);
            tblMain.Controls.Add(gRecipes, 0, 1);
            tblMain.Controls.Add(btnNew, 2, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.848772F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80.15123F));
            tblMain.Size = new Size(699, 529);
            tblMain.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(3, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.Location = new Point(202, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(167, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipes, 3);
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 108);
            gRecipes.Name = "gRecipes";
            gRecipes.RowHeadersWidth = 51;
            gRecipes.RowTemplate.Height = 29;
            gRecipes.Size = new Size(693, 418);
            gRecipes.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Left;
            btnNew.Location = new Point(375, 38);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(106, 29);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // RecipeSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 529);
            Controls.Add(tblMain);
            Name = "RecipeSearch";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView gRecipes;
        private Button btnNew;
    }
}