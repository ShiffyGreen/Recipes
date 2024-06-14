using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=tcp:shiffygreen.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User ID=shiffyadmin;Password=Bestfriend#1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        [Test]
        public void InsertNewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "Cant run test no cuisines in db");

            int usersid = SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Cant run test no users in db");

            string recipename = "Muddy Buddies" + DateTime.Now;

            int maxcalories = SQLUtility.GetFirstCOlumnFirstRowValue("select max(caloriecount) from recipe");
            maxcalories = maxcalories + 20;

            TestContext.WriteLine("insert recipe with recipename = " + recipename);
            r["cuisineid"] = cuisineid;
            r["usersid"] = usersid;
            r["recipename"] = recipename;
            r["caloriecount"] = maxcalories;
            r["DateDrafted"] = "2024-1-1";
            r["DatePublished"] = "2024-3-3";
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstCOlumnFirstRowValue("select * from recipe where caloriecount = " + maxcalories);

            Assert.IsTrue(newid > 0, "recipe with caloriecount = " + maxcalories + "is not found in db");
            TestContext.WriteLine("Recipe with " + maxcalories + " is found in db with pk value = " + newid);
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
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, recipename, caloriecount from recipe r left join RecipeIngredient i on r.recipeid = i.recipeid where i.RecipeIngredientid is null");
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
            Recipe.Delete(dt);
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
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();

            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            string recipename = SQLUtility.GetFirstCOlumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <>  " + recipeid);
            string currentname = SQLUtility.GetFirstCOlumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
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
            TestContext.WriteLine("Ensure that app loads recipe" + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = 0;
            if (dt.Rows.Count > 0)
            {
                loadedid = (int)dt.Rows[0]["recipeid"];
            }
            Assert.IsTrue(loadedid == recipeid, (int)dt.Rows[0]["recipeid"] + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")" + recipeid);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "a";
            int num = SQLUtility.GetFirstCOlumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "There no recipes that match the search for " + num);
            TestContext.WriteLine(num + " recipe that match " + criteria);
            TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");

            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of recipe search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipe search is " + results);
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

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstCOlumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}