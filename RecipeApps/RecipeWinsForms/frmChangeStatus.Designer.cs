namespace RecipeWinsForms
{
    partial class frmChangeStatus
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
            lblCurrentStatusWord = new Label();
            lblCurrentStatus = new Label();
            tblstatus = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublished = new Button();
            btnArchived = new Button();
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            tblstatus.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblCurrentStatusWord
            // 
            lblCurrentStatusWord.Anchor = AnchorStyles.Right;
            lblCurrentStatusWord.AutoSize = true;
            lblCurrentStatusWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentStatusWord.Location = new Point(258, 70);
            lblCurrentStatusWord.Name = "lblCurrentStatusWord";
            lblCurrentStatusWord.Size = new Size(139, 28);
            lblCurrentStatusWord.TabIndex = 1;
            lblCurrentStatusWord.Text = "Current Status:";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentStatus.Location = new Point(403, 60);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(237, 47);
            lblCurrentStatus.TabIndex = 2;
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblstatus
            // 
            tblstatus.ColumnCount = 5;
            tblMain.SetColumnSpan(tblstatus, 2);
            tblstatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblstatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblstatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblstatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblstatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblstatus.Controls.Add(lblDrafted, 1, 0);
            tblstatus.Controls.Add(lblPublished, 2, 0);
            tblstatus.Controls.Add(lblArchived, 3, 0);
            tblstatus.Dock = DockStyle.Fill;
            tblstatus.Location = new Point(3, 115);
            tblstatus.Name = "tblstatus";
            tblstatus.RowCount = 1;
            tblstatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblstatus.Size = new Size(794, 50);
            tblstatus.TabIndex = 3;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom;
            lblDrafted.AutoSize = true;
            lblDrafted.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrafted.Location = new Point(203, 27);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(67, 23);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(353, 27);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(84, 23);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom;
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(515, 27);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(76, 23);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 5;
            tblMain.SetColumnSpan(tblDates, 2);
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8162727F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.47244F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.947506F));
            tblDates.Controls.Add(lblStatusDates, 0, 0);
            tblDates.Controls.Add(txtDateDrafted, 1, 0);
            tblDates.Controls.Add(txtDatePublished, 2, 0);
            tblDates.Controls.Add(txtDateArchived, 3, 0);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 171);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 1;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDates.Size = new Size(794, 50);
            tblDates.TabIndex = 4;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusDates.Location = new Point(51, 13);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(104, 23);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Left;
            txtDateDrafted.Location = new Point(161, 11);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(146, 27);
            txtDateDrafted.TabIndex = 1;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left;
            txtDatePublished.Location = new Point(319, 11);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(144, 27);
            txtDatePublished.TabIndex = 2;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.Location = new Point(475, 11);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(149, 27);
            txtDateArchived.TabIndex = 3;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 7;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tblButtons.Controls.Add(btnDraft, 1, 0);
            tblButtons.Controls.Add(btnPublished, 3, 0);
            tblButtons.Controls.Add(btnArchived, 5, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 227);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(794, 50);
            tblButtons.TabIndex = 5;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(100, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(144, 44);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublished
            // 
            btnPublished.Dock = DockStyle.Fill;
            btnPublished.Location = new Point(319, 3);
            btnPublished.Name = "btnPublished";
            btnPublished.Size = new Size(144, 44);
            btnPublished.TabIndex = 1;
            btnPublished.Text = "Published";
            btnPublished.UseVisualStyleBackColor = true;
            // 
            // btnArchived
            // 
            btnArchived.Dock = DockStyle.Fill;
            btnArchived.Location = new Point(533, 3);
            btnArchived.Name = "btnArchived";
            btnArchived.Size = new Size(144, 44);
            btnArchived.TabIndex = 2;
            btnArchived.Text = "Archived";
            btnArchived.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatusWord, 0, 1);
            tblMain.Controls.Add(lblCurrentStatus, 1, 1);
            tblMain.Controls.Add(tblstatus, 0, 2);
            tblMain.Controls.Add(tblDates, 0, 3);
            tblMain.Controls.Add(tblButtons, 0, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 299F));
            tblMain.Size = new Size(800, 580);
            tblMain.TabIndex = 2;
            // 
            // lblRecipeName
            // 
            tblMain.SetColumnSpan(lblRecipeName, 2);
            lblRecipeName.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(794, 56);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(tblMain);
            Name = "frmChangeStatus";
            Text = "frmChangeStatus";
            tblstatus.ResumeLayout(false);
            tblstatus.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCurrentStatusWord;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblstatus;
        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblDates;
        private Label lblStatusDates;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublished;
        private Button btnArchived;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
    }
}