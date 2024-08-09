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
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
            GetUsers();

        }

      
        private void GetUsers()
        {
            DataTable dt = Recipe.GetUsersList(true);
            txtUsers.DataSource = dt;
            txtUsers.DisplayMember = "userName";
            txtUsers.ValueMember = "UsersId";

        }
        private void CreateCookbook()
        {
            int usersid = WindowsFormUtility.GetIdFromComboBox(txtUsers);

            Cursor = Cursors.WaitCursor;
            try
            {

                Cookbook.AutoCreateCookbook(usersid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook),usersid);
                    this.Close();
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

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }

    }
}
