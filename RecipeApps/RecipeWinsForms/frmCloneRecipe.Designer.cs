namespace RecipeWinsForms
{
    partial class frmCloneRecipe
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
            btnClone = new Button();
            lstRecipeList = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.19149F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8085136F));
            tblMain.Controls.Add(btnClone, 0, 1);
            tblMain.Controls.Add(lstRecipeList, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.75F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(576, 560);
            tblMain.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClone.Location = new Point(152, 66);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(151, 39);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // lstRecipeList
            // 
            lstRecipeList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstRecipeList.FormattingEnabled = true;
            lstRecipeList.Location = new Point(3, 32);
            lstRecipeList.Name = "lstRecipeList";
            lstRecipeList.Size = new Size(268, 28);
            lstRecipeList.TabIndex = 0;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 560);
            Controls.Add(tblMain);
            Name = "frmCloneRecipe";
            Text = "Clone Recipe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnClone;
        private ComboBox lstRecipeList;
    }
}