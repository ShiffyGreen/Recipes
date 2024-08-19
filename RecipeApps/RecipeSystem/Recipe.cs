using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUsersList(bool includeblank = false)
        {

            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;


        }

        public static void Save(DataTable dtrecipe)
        {
            if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("cannot call Recipe Save method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd,"@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetRecipeSummary(bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeListGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@Includeblank", includeblank);
            }
            return SQLUtility.GetDataTable(cmd);
        }

        public static void ChangeStatus(int recipeid, string newstatus)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("ChangeStatus");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SQLUtility.SetParamValue(cmd, "@NewStatus", newstatus);            
            SQLUtility.ExecuteSQL(cmd);
        }
       
    }
}
