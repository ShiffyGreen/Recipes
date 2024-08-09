using CPUFramework;
using CPUWindowsFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinsForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEmun { Users, Cuisine, Ingredient, UnitOfMeasure, Course }
        DataTable dtlist = new();
        TableTypeEmun currenttabletype = TableTypeEmun.Users;
        string deletecolname = "deletcol";

        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gdata.CellContentClick += Gdata_CellContentClick;
            SetupRadioButtons();
            BindData(TableTypeEmun.Users);
        }

        private void BindData(TableTypeEmun tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gdata.Columns.Clear();
            gdata.DataSource = dtlist;
            WindowsFormUtility.AddDeleteButtonToGrid(gdata, deletecolname);
            WindowsFormUtility.FormatGridGorEdit(gdata, tabletype.ToString());
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        private void Delete(int rowindex)
        {
            var response = MessageBox.Show($"Are you sure you want to delete this {currenttabletype} and all its related records?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                int id = WindowsFormUtility.GetIdFromGrid(gdata, rowindex, currenttabletype.ToString() + "Id");
                if (id != 0)
                {
               
                        DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                        BindData(currenttabletype);
               
                }
                else if (id == 0 && rowindex < gdata.Rows.Count)
                {
                    gdata.Rows.Remove(gdata.Rows[rowindex]);
                }
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
        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionsPanel.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEmun.Users;
            optCuisines.Tag = TableTypeEmun.Cuisine;
            optIngredients.Tag = TableTypeEmun.Ingredient;
            optMeasurements.Tag = TableTypeEmun.UnitOfMeasure;
            optCourses.Tag = TableTypeEmun.Course;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEmun)
            {
                BindData((TableTypeEmun)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
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

        private void Gdata_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gdata.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }
    }
}
