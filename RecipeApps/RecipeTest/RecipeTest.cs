using System.Data;
using System.Configuration;

namespace RecipeTest
{
    public class Tests
    {
        string liveconnstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;
        //string devconnstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        //string testliveconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(liveconnstring, true);
        }
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(liveconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return dt;
        }

        private int GetFirstCOlumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(liveconnstring, false);
            n = SQLUtility.GetFirstCOlumnFirstRowValue(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return n;
        }
        public string GetFirstCOlumnFirstRowValueAsString(string sql)
        {
            DataTable dt = new();
            dt = GetDataTable(sql);
            sql = dt.Rows[0][0].ToString();
            return sql.ToString();
        }


        [Test]
        public void InsertNewRecipe()
        {
            
            int cuisineid = SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "Cant run test no cuisines in db");

            int usersid = SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Cant run test no users in db");

            string recipename = "Muddy Buddies" + DateTime.Now;

            int maxcalories = SQLUtility.GetFirstCOlumnFirstRowValue("select max(caloriecount) from recipe");
            maxcalories = maxcalories + 20;

            TestContext.WriteLine("insert recipe with recipename = " + recipename);
            bizRecipe rec = new();
            rec.CuisineId = cuisineid;
            rec.UsersId = usersid;
            rec.RecipeName = recipename;
            rec.CalorieCount = maxcalories;
            rec.DateDrafted = DateTime.Now;
            //rec.DatePublished = DateTime.Now;
            
            rec.Save();

            int newid = rec.RecipeId;
            Assert.IsTrue(newid > 0, "recipe with caloriecount = " + maxcalories + "is not found in db");
            TestContext.WriteLine("Recipe with " + maxcalories + " calories is found in db with pk value = " + newid);

        }

        [Test]
        public void ChangeExistingRecipeCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't test");
            int caloriecount = SQLUtility.GetFirstCOlumnFirstRowValue("select caloriecount from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriecount for recipeid " + recipeid + " is " + caloriecount);
            caloriecount = caloriecount + 10;
            TestContext.WriteLine("change caloriecount to " + caloriecount);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["caloriecount"] = caloriecount;
            Recipe.Save(dt);

            int newcaloriecount = SQLUtility.GetFirstCOlumnFirstRowValue("select caloriecount from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcaloriecount == caloriecount, "caloriecount for recipe (" + recipeid + ") = " + newcaloriecount);
            TestContext.WriteLine("caloriecount for recipe (" + recipeid + ") = " + newcaloriecount);

        }


        [Test]
        public void ChangeExistingRecipeInvalidCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't test");
            int caloriecount = SQLUtility.GetFirstCOlumnFirstRowValue("select caloriecount from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("caloriecount for recipeid " + recipeid + " is " + caloriecount);
            caloriecount = -1;
            TestContext.WriteLine("change caloriecount to " + caloriecount);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["caloriecount"] = caloriecount;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, caloriecount from recipe r left join RecipeIngredient ri on r.RecipeId = ri.RecipeId left join Directions d on r.RecipeId = d.RecipeId where ri.RecipeIngredientid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["CalorieCount"];
            }
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("existing recipe with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete();
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeById()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, caloriecount from recipe r left join RecipeIngredient ri on r.RecipeId = ri.RecipeId left join Directions d on r.RecipeId = d.RecipeId where ri.RecipeIngredientid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["CalorieCount"];
            }
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("existing recipe with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe rec = new();
            rec.Delete(recipeid);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }


        [Test]
        public void DeleteRecipeByDataTable()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, caloriecount from recipe r left join RecipeIngredient ri on r.RecipeId = ri.RecipeId left join Directions d on r.RecipeId = d.RecipeId where ri.RecipeIngredientid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["CalorieCount"];
            }
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("existing recipe with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe rec = new();
            rec.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeWithIngredients()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, caloriecount from recipe r join RecipeIngredient i on r.recipeid = i.recipeid");
            int recipeId = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeId = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"] + " " + dt.Rows[0]["caloriecount"];
            }
            Assume.That(recipeId > 0, "No recipe with ingredients in DB, can't test");
            TestContext.WriteLine("existing recipe with ingredients, with id = " + recipeId + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeId);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));


            TestContext.WriteLine("unable to delete recipe because of exeption");
        }

        [Test]
        public void DeleteRecipeThatPublishedOrNotArchive30Days()
        {
            DataTable dt = SQLUtility.GetDataTable(@"
                select top 1 r.recipeid, recipename, caloriecount 
                from recipe r 
                join RecipeIngredient i on r.recipeid = i.recipeid
                where r.currentstatus = 'published'
                or datediff(day,r.datearchived,getdate()) <= 30");
            int recipeId = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeId = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"] + " " + dt.Rows[0]["caloriecount"];
            }
            Assume.That(recipeId > 0, "No recipe with ingredients in DB, can't test");
            TestContext.WriteLine("existing recipe with ingredients, with id = " + recipeId + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeId);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));


            TestContext.WriteLine("unable to delete recipe because of exeption");
        }

        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();

            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <>  " + recipeid);
            string currentname = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
            Assume.That(recipename != "", "Cannot run test because there is no other recipe record in the table");

            TestContext.WriteLine("change recipeid " + recipeid + " from " + currentname + " to " + recipename + " which belongs to a dif recipe");
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            int loadedid = rec.RecipeId;
            Assert.IsTrue(loadedid == recipeid,loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ") " + recipeid);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "a";
            int num = SQLUtility.GetFirstCOlumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "There no recipes that match the search for " + num);
            TestContext.WriteLine(num + " recipe that match " + criteria);
            TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");
            bizRecipe rec = new();
            List<bizRecipe> lst = rec.Search(criteria);
            Assert.IsTrue(lst.Count == num, "Results of recipe search does not match number of recipes, " + lst.Count + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipe search is " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = GetFirstCOlumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank == true) { recipecount = recipecount + 1; }
            Assume.That(recipecount > 0, "No recipe in DB, cant test");
            TestContext.WriteLine("Num of recipe in DB = " + recipecount);
            TestContext.WriteLine("Ensure that Num of rows return by app matches " + recipecount);
            bizRecipe rec = new();
            var lst = rec.GetList(includeblank);

            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of rows in recipe return by app = " + lst.Count);
        }
        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = SQLUtility.GetFirstCOlumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisine in DB, cant test");
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that Num of rows return by app matches " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count > 0, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of rows in cuisine return by app = " + dt.Rows.Count);
        }
        [Test]
        public void SearchIngredients()
        {
            string ing = "a";
            int num = SQLUtility.GetFirstCOlumnFirstRowValue("select total = count(*) from ingredient where ingredientname like '%" + ing + "%'");
            Assume.That(num > 0, "There no ingredients that match the search for " + num);
            TestContext.WriteLine(num + " ingredient that match " + ing);
            TestContext.WriteLine("Ensure that ingredient search returns " + num + " rows");
            bizIngredient ingr = new();
            List<bizIngredient> lst = ingr.Search(ing);
            Assert.IsTrue(lst.Count == num, "Results of ingredient search does not match number of ingredients, " + lst.Count + " <> " + num);
            TestContext.WriteLine("Number of rows returned by ingredient search is " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = GetFirstCOlumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank == true) { ingredientcount = ingredientcount + 1; }
            Assume.That(ingredientcount > 0, "No ingredient in DB, cant test");
            TestContext.WriteLine("Num of ingredient in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that Num of rows return by app matches " + ingredientcount);
            bizIngredient ing = new();
            var lst = ing.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of rows in ingredient return by app = " + lst.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 recipeid from recipe");
        }

        private static string GetFirstColumnFirstRowValueAsString(string sql)
        {
            DataTable dt = SQLUtility.GetDataTable(sql);
            sql = dt.Rows[0][0].ToString();
            return sql.ToString();
        }
    }
}