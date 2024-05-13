using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;


namespace RecipeWinsForms
{
    public partial class RecipeSearch : Form
    {
        public RecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += gRecipes_CellDoubleClick;
            FormatGrid();
        }


        private void FormatGrid()
        {
            gRecipes.AllowUserToAddRows = false;
            gRecipes.ReadOnly = true;
            gRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void SearchForRecipe(string recipe)
        {
            string sql = "select recipeid, recipename from recipe r where r.recipename like '%" + recipe + "%'";
            Debug.Print(sql);
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipes.DataSource = dt;
            gRecipes.Columns["recipeid"].Visible = false;
        }
        private void ShowRecipeForm(int rowindex)
        {
            int id = (int)gRecipes.Rows[rowindex].Cells["recipeid"].Value;
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtSearch.Text);
        }
        private void gRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

    }
}
