using CPUFramework;
using CPUWindowsFormsFramework;
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

namespace RecipeWinsForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }



        public void ShowForm(int recipeid)
        {
            string sql = "select * from recipe r join cuisine c on r.cuisineid = c.cuisineid join users u on r.usersid = u.usersid where recipeid = " + recipeid.ToString();
            Debug.Print(sql);
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = SQLUtility.GetDataTable("Select CuisineId, CuisineType from cuisine");
            txtCuisine.DataSource = dtcuisine;
            txtCuisine.ValueMember = "CuisineId";
            txtCuisine.DisplayMember = "CuisineType";
            txtCuisine.DataBindings.Add("SelectedValue", dtrecipe, "CuisineId");
            DataTable dtusers = SQLUtility.GetDataTable("Select UsersId, lastname from Users");
            txtUser.DataSource = dtusers;
            txtUser.ValueMember = "UsersId";
            txtUser.DisplayMember = "lastname";
            txtUser.DataBindings.Add("SelectedValue", dtrecipe, "UsersId");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtCurrentStatus, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtCalorieCount, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtPictureName, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"datedrafted = '{r["datedrafted"]}',",
                    $"caloriecount = '{r["caloriecount"]}',",
                    $"usersid = '{r["usersid"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe(CuisineId, UsersId, RecipeName, DateDrafted, CalorieCount,datepublished) ";
                sql += $"select '{r["CuisineId"]}', {r["UsersId"]}, '{r["RecipeName"]}', '{r["DateDrafted"]}', '{r["CalorieCount"]}','{r["Datepublished"]}'";
            }

            Debug.Print("------------");
            Debug.Print(sql);
            SQLUtility.GetDataTable(sql);
        }
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
