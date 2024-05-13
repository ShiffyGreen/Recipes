﻿namespace RecipeWinsForms
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
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.91416F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.08584F));
            tblMain.Controls.Add(txtSearch, 0, 0);
            tblMain.Controls.Add(btnSearch, 1, 0);
            tblMain.Controls.Add(gRecipes, 0, 1);
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
            txtSearch.Size = new Size(271, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.Location = new Point(281, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipes, 2);
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 108);
            gRecipes.Name = "gRecipes";
            gRecipes.RowHeadersWidth = 51;
            gRecipes.RowTemplate.Height = 29;
            gRecipes.Size = new Size(693, 418);
            gRecipes.TabIndex = 2;
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
    }
}