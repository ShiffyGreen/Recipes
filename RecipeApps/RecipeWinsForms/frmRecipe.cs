using CPUFramework;
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
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select * from recipe where recipeid = " + recipeid.ToString();
            Debug.Print(sql);
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipe.DataBindings.Add("Text", dt, "RecipeName");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtCurrentStatus.DataBindings.Add("Text", dt, "CurrentStatus");
            txtCalories.DataBindings.Add("Text", dt, "CalorieCount");
            txtRecipePicture.DataBindings.Add("Text", dt, "PictureName");
            this.Show();
        }
    }
}
