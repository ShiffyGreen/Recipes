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
            string sql = "select recipeid, recipename from recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select * from recipe r join cuisine c on r.cuisineid = c.cuisineid join users u on r.usersid = u.usersid where recipeid = " + recipeid.ToString(); 
            return SQLUtility.GetDataTable(sql);
        }
        //LB: An improvement would be to combine the two methods below. You can have one method called GetList and pass in a parameter which will specify the table name.
        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("Select CuisineId, CuisineType from cuisine");
        }

        public static DataTable GetUsersList()
        {
            return SQLUtility.GetDataTable("Select UsersId, lastname from Users");
        }

        public static void Save(DataTable dtrecipe)
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

            SQLUtility.GetDataTable(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
