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

        }
        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            Recipe.ChangeStatus(recipeid, "drafted");
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
        }
        private void BtnArchived_Click(object? sender, EventArgs e)
        {
            Recipe.ChangeStatus(recipeid, "archived");
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
        }

        private void BtnPublished_Click(object? sender, EventArgs e)
        {
            Recipe.ChangeStatus(recipeid, "published");
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
        }

    }
}
