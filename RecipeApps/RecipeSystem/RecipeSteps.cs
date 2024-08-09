using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public static class RecipeSteps
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("DirectionsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int Recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = Recipeid;
            }
            SQLUtility.SaveDataTable(dt, "DirectionsUpdate");
        }
        public static void Delete(int recipedirectionsid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DirectionsDelete");
            cmd.Parameters["@DirectionsId"].Value = recipedirectionsid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}

