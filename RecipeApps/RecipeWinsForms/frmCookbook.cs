using CPUFramework;
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
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;

        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.Shown += FrmCookbook_Shown;
            btnRecipeSave.Click += BtnRecipeSave_Click;
            grecipe.CellContentClick += Grecipe_CellContentClick;
        }

     

        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipe();
        }

        public void LoadFormCookbook(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUsersList();
            txtUser.DataSource = dtusers;
            txtUser.ValueMember = "UsersId";
            txtUser.DisplayMember = "lastname";
            txtUser.DataBindings.Add("SelectedValue", dtcookbook, "UsersId");
            WindowsFormUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            ckActive.DataBindings.Add("Checked", dtcookbook, "ActiveOrNot", true, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = GetCookbookDesc();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipe()
        {
            dtcookbookrecipe = CookbookRecipe.LoadByCookbookId(cookbookid);
            grecipe.Columns.Clear();
            grecipe.DataSource = dtcookbookrecipe;
            WindowsFormUtility.AddComboBoxToGrid(grecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.AddDeleteButtonToGrid(grecipe, deletecolname);         
            WindowsFormUtility.FormatGridGorEdit(grecipe, "CookbookRecipe");
            WindowsFormUtility.DoFormatGrid(grecipe,"Recipe");
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {

            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
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
        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(grecipe, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < grecipe.Rows.Count)
            {
                grecipe.Rows.RemoveAt(rowIndex);
            }
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnRecipeSave.Enabled = b;

        }
        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsstring(dtcookbook, "Cookbookname");
            }
            return value;
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnRecipeSave_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }
        private void Grecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }
    }
}
