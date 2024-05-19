using System.Data;
using System.Diagnostics;
using CPUFramework;
using CPUWindowsFormsFramework;


namespace RecipeWinsForms
{
    public partial class RecipeSearch : Form
    {
        public RecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipes.CellDoubleClick += gRecipes_CellDoubleClick;
            WindowsFormUtility.FormatGridForSearchResults(gRecipes);
            btnNew.Click += BtnNew_Click;
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
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipes.Rows[rowindex].Cells["recipeid"].Value;
            }
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
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

    }
}
