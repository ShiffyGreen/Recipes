using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public static class Cookbook
    {
        public static DataTable GetCookbookList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtrecipe, bool isActive = false)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("cannot call Cookbook Save method because there are no rows in the table");
            }
            DataRow r = dtrecipe.Rows[0];
            r["ActiveorNot"] = isActive;
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void AutoCreateCookbook(int usersid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@Usersid", usersid);
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
