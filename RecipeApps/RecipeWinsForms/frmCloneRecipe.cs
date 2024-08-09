using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinsForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }


        private void BindData()
        {
            //WindowsFormUtility.SetListBinding(lstRecipeList,DataMaintenance.GetDataList("Recipe",true),null,"Recipe");
            DataTable dtRecipeName = Recipe.GetRecipeSummary();
            lstRecipeList.DataSource = dtRecipeName;
            lstRecipeList.ValueMember = "RecipeId";
            lstRecipeList.DisplayMember = "RecipeName";
        }
        private void CLone()
        {
            int recipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeList);
            int newrecipeid = 0;
            Cursor = Cursors.WaitCursor;
            try
            {
                SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
                SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
                SQLUtility.SetParamValue(cmd, "@NewRecipeId", DBNull.Value);
                SQLUtility.SetParamValue(cmd, "@Message", DBNull.Value);
                SQLUtility.ExecuteSQL(cmd);

                newrecipeid = (int)cmd.Parameters["@NewrecipeId"].Value;
                string message = cmd.Parameters["@Message"].Value.ToString();

                if(newrecipeid > 0)
                {
                    int id = newrecipeid;
                    if (this.MdiParent != null && this.MdiParent is frmMain)
                    {
                        ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe),id);
                        this.Close();
                    }
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CLone();
        }
    }
}
