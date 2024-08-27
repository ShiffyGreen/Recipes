using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinsForms
{
    public partial class frmChangeStatus : Form
    {
        int recipeid = 0;
        DataTable dtrecipe = new();
        BindingSource bindsource = new();

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublished.Click += BtnPublished_Click;
            btnArchived.Click += BtnArchived_Click;
            
        }


        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblCurrentStatus, bindsource);
            EnableButtons();
        }
        private void EnableButtons()
        {
            btnDraft.Enabled = lblCurrentStatus.Text != "draft";
            btnPublished.Enabled = lblCurrentStatus.Text != "published";
            btnArchived.Enabled = lblCurrentStatus.Text != "archived";
        }
        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change the status of your recipe to draft?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.ChangeStatus(recipeid, "drafted");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void BtnArchived_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change the status of your recipe to archived?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.ChangeStatus(recipeid, "archived");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            
        }

        private void BtnPublished_Click(object? sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to change the status of your recipe to published?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.ChangeStatus(recipeid, "published");
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            
        }

    }
}
