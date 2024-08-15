using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipesteps = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int recipeid = 0;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            this.FormClosing += FrmRecipe_FormClosing;
            this.Shown += FrmRecipe_Shown;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredients.DataError += GIngredients_DataError;
            gSteps.DataError += GSteps_DataError;
            
        }

       

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredients();
            LoadRecipeSteps();
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = Recipe.GetCuisineList();
            txtCuisine.DataSource = dtcuisine;
            txtCuisine.ValueMember = "CuisineId";
            txtCuisine.DisplayMember = "CuisineType";
            txtCuisine.DataBindings.Add("SelectedValue", dtrecipe, "CuisineId");
            DataTable dtusers = Recipe.GetUsersList();
            txtUser.DataSource = dtusers;
            txtUser.ValueMember = "UsersId";
            txtUser.DisplayMember = "lastname";
            txtUser.DataBindings.Add("SelectedValue", dtrecipe, "UsersId");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(txtCurrentStatus, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalorieCount, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonsEnabledBasedOnNewRecord();

        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeIngredients.LoadByRecipeId(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("UnitOfMeasure"), "UnitOfMeasure", "MeasureName");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormUtility.FormatGridGorEdit(gIngredients, "RecipeIngredient");
        }

        private void LoadRecipeSteps()
        {
            dtrecipesteps = RecipeSteps.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipesteps;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormUtility.FormatGridGorEdit(gSteps, "Directions");
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                if (dtrecipe.Rows[0]["DateDrafted"] == DBNull.Value)
                {
                    dtrecipe.Rows[0]["DateDrafted"] = DateTime.Now.ToString("dd MMM yyyy");
                }
                if (dtrecipe.Rows[0]["CurrentStatus"] == DBNull.Value)
                {
                    dtrecipe.Rows[0]["CurrentStatus"] = "draft"; 
                }
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {

            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe App", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }

        private void SaveRecipeIngredients()
        {
            try
            {
                RecipeIngredients.SaveTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void SaveRecipeSteps()
        {
            try
            {
                RecipeSteps.SaveTable(dtrecipesteps, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeSteps(int rowIndex)
        {
            try
            {
                int id = WindowsFormUtility.GetIdFromGrid(gSteps, rowIndex, "DirectionsId");
                if (id > 0)
                {

                    RecipeSteps.Delete(id);
                    LoadRecipeSteps();

                }
                else if (id < gIngredients.Rows.Count)
                {
                    gIngredients.Rows.RemoveAt(rowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeIngredient(int rowIndex)
        {
            try
            {
                int id = WindowsFormUtility.GetIdFromGrid(gIngredients, rowIndex, "RecipeIngredientId");
                if (id > 0)
                {

                    RecipeIngredients.Delete(id);
                    LoadRecipeIngredients();

                }
                else if (id < gIngredients.Rows.Count)
                {
                    gIngredients.Rows.RemoveAt(rowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;

        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsstring(dtrecipe, "Recipename");
            }
            return value;
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }
        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeSteps(e.RowIndex);
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
        }
        private void GSteps_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter the correct data type", Application.ProductName);
        }

        private void GIngredients_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please enter the correct data type", Application.ProductName);
        }


        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

    }
}
