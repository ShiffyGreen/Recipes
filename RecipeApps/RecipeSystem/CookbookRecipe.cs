using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public static class CookbookRecipe
    {
        public static DataTable LoadByCookbookId(int CookbookId)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = CookbookId;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int CookbookId)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["CookbookId"] = CookbookId;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }
        public static void Delete(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("cookbookrecipeDelete");
            cmd.Parameters["@cookbookrecipeId"].Value = cookbookrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
