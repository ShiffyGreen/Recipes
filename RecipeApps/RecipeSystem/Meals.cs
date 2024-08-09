using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public static class Meals
    {
        public static DataTable GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealListGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
