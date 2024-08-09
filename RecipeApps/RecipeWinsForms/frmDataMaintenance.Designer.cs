namespace RecipeWinsForms
{
    partial class frmDataMaintenance
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
            pnlOptionsPanel = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            gdata = new DataGridView();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gdata).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.625F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.375F));
            tblMain.Controls.Add(pnlOptionsPanel, 0, 1);
            tblMain.Controls.Add(gdata, 1, 1);
            tblMain.Controls.Add(btnSave, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.55556F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // pnlOptionsPanel
            // 
            pnlOptionsPanel.Controls.Add(optUsers);
            pnlOptionsPanel.Controls.Add(optCuisines);
            pnlOptionsPanel.Controls.Add(optIngredients);
            pnlOptionsPanel.Controls.Add(optMeasurements);
            pnlOptionsPanel.Controls.Add(optCourses);
            pnlOptionsPanel.Dock = DockStyle.Fill;
            pnlOptionsPanel.Location = new Point(3, 3);
            pnlOptionsPanel.Name = "pnlOptionsPanel";
            pnlOptionsPanel.Size = new Size(135, 408);
            pnlOptionsPanel.TabIndex = 1;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Location = new Point(3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(65, 24);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(3, 33);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(83, 24);
            optCuisines.TabIndex = 1;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Location = new Point(3, 63);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(104, 24);
            optIngredients.TabIndex = 2;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(3, 93);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(126, 24);
            optMeasurements.TabIndex = 3;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.AutoSize = true;
            optCourses.Location = new Point(3, 123);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(81, 24);
            optCourses.TabIndex = 4;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // gdata
            // 
            gdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdata.Dock = DockStyle.Fill;
            gdata.Location = new Point(144, 3);
            gdata.Name = "gdata";
            gdata.RowHeadersWidth = 51;
            gdata.RowTemplate.Height = 29;
            gdata.Size = new Size(653, 408);
            gdata.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(703, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptionsPanel.ResumeLayout(false);
            pnlOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlOptionsPanel;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private DataGridView gdata;
        private Button btnSave;
    }
}