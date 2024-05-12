-- SM Excellent work! See comments, fix and resubmit (Meal details page: b).
use HeartyHearthDB
go
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Name = 'Recipe', num = count(r.RecipeId) from Recipe r 
union select 'Meals', count(m.MealId) from meal m 
union select 'Cookbook', count(c.cookbookid) from Cookbook c 

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
    Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates 
*/
select RecipeName = case
    when CurrentStatus = 'archived' then concat ('<span style="color:gray">', r.RecipeName, '</span>')
    else r.RecipeName end,
    r.CurrentStatus, 
    DatePublished = isnull(convert(varchar,r.DatePublished,101),''), 
    DateArchived =isnull(convert(varchar,r.DateArchived,101),''),
    u.UserName, r.CalorieCount,
    NumofIngredients = count(ri.IngredientId)
from Recipe r 
join users u 
on r.UsersId = u.UsersId 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.CurrentStatus in ('Published','Archived')
group by r.RecipeName,r.CurrentStatus,r.DatePublished,r.DateArchived,u.UserName,r.CalorieCount
order by r.CurrentStatus desc 



/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a
select r.RecipeName,r.CalorieCount, r.picturename,NumofIngredients = count(distinct ri.IngredientId), NumofDirections = count(distinct d.DirectionsSequence)
from recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Directions d 
on r.RecipeId = d.RecipeId
where r.recipename = 'Chocolate Chip Cookies'
group by r.RecipeName,r.CalorieCount,r.picturename
--b
select Ingredients = concat (ri.Amount, ' ', u.MeasureName, ' ', i.IngredientName)
from Ingredient i
join RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
join Recipe r 
on ri.RecipeId = r.RecipeId
join UnitOfMeasure u 
on ri.UnitOfMeasureId = u.UnitOfMeasureId
where r.RecipeName = 'Muddy Buddies'
order by ri.IngredientSequence
--c
select d.Instructions
from Directions d 
join Recipe r 
on d.RecipeId = r.RecipeId 
where r.RecipeName = 'Muddy Buddies'
order by d.DirectionsSequence

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, u.UserName, NumOfCalories = sum (r.CalorieCount), NumOfCourses = count (distinct mc.CourseId), NumOfRecipes = count (distinct r.RecipeId)
from meal m
join users u
on m.UsersId = u.UsersId
join MealCourse mc
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mcr.MealCourseId = mc.MealCourseId
join recipe r
on mcr.RecipeId = r.RecipeId
where m.ActiveOrNot = 1
group by m.MealName, u.UserName
order by m.MealName


/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
            Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
                    Main: Side dish - Roasted cucumbers with mustard
*/
--a
select m.MealName, u.UserName, m.DateCreated
from Meal m 
join users u 
on m.UsersId = u.UsersId
where m.MealName = 'Breakfast Bash'
--b
-- SM Only main course should show if it's main or side dish
select ListofRecipes = case when mcr.ismaindish = 1 then concat('<b>',c.CourseName,': Main Dish - ',r.recipename,'</b>')  
            when mcr.ismaindish = 0 and c.CourseName = 'Main Course' then concat(c.CourseName,': Side Dish -',r.RecipeName) 
            else concat(c.CourseName,': ',r.RecipeName) end
from Recipe r
join MealCourseRecipe mcr
on r.recipeid = mcr.RecipeId
join MealCourse mc 
on mcr.MealCourseId = mc.MealCourseId
join Meal m 
on mc.MealId = m.MealId
join Course c 
on mc.CourseId = c.CourseId
where m.MealName = 'Breakfast Bash'


/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.

*/
select cb.CookbookName, u.UserName, NumofRecipes = count(cbr.RecipeId)
from Cookbook cb 
join Users u 
on cb.UsersId = u.UsersId
join CookbookRecipe cbr 
on cb.CookbookId = cbr.CookbookId
where cb.ActiveOrNot = 'true'
group by cb.CookbookName, u.UserName
order by cb.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a
select cb.CookbookName, u.UserName, cb.datecreated, cb.Price, NumofRecipes = count(cbr.RecipeId)
from Cookbook cb 
join Users u 
on cb.UsersId = u.UsersId
join CookbookRecipe cbr 
on cbr.CookbookId = cb.CookbookId
where cb.CookbookName = 'Cooking Hacks'
group by cb.CookbookName, u.UserName, cb.datecreated, cb.Price
--b
select r.RecipeName, c.CuisineType, NumofIngredients = count(distinct ri.IngredientId), AmountofSteps = count(distinct d.DirectionsId)
from Recipe r 
join CookbookRecipe cbr 
on cbr.RecipeId = r.RecipeId
join Cookbook cb 
on cb.CookbookId = cbr.CookbookId 
join Cuisine c 
on r.CuisineId = c.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join Directions d 
on r.RecipeId = d.RecipeId
where cb.CookbookName = 'Cooking Hacks'
group by r.RecipeName, c.CuisineType

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a
select RecipeName = concat(upper(substring(reverse(r.RecipeName),1,1)),lower(substring(reverse(r.RecipeName),2,100))), cbr.CookbookId,
        PictureName =  concat('Recipe_',replace(concat(upper(substring(reverse(r.RecipeName),1,1)),lower(substring(reverse(r.RecipeName),2,100))),' ','_'),'.jpg')
from Recipe r 
join CookbookRecipe cbr 
on r.RecipeId = cbr.RecipeId

--b
;
with x as(
select lastofDirections = max(d.DirectionsSequence), r.RecipeName
from Directions d 
join Recipe r 
on d.RecipeId = r.RecipeId
group by r.RecipeName
)
select d.Instructions
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Directions d 
on r.RecipeId = d.RecipeId 
where d.DirectionsSequence = x.lastofDirections

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a
select u.UserName, NumofRecipes = count(r.RecipeId), r.CurrentStatus
from Recipe r 
left join Users u 
on r.UsersId = u.UsersId
group by u.UserName, r.CurrentStatus
--b
select u.UserName, NumofRecipes = count(r.RecipeId), AvrageAmountofDays = avg(datediff(day,r.DateDrafted,r.DatePublished))
from Recipe r 
join users u 
on r.UsersId = u.UsersId
group by u.UserName 
--c
select u.username, NumofMeals = count(m.MealId), 
        TotalActiveMeals = sum(case when m.ActiveOrNot = 1 then 1 else 0 end),
        TotalInactiveMeals = sum(case when m.ActiveOrNot = 1 then 1 else 0 end)
from Users u 
join meal m 
on u.UsersId = m.UsersId
group by u.UserName, m.ActiveOrNot
--d
select u.username, NumofCookbooks = count(cb.CookbookId), 
        TotalActiveCookbooks = sum(case when cb.ActiveOrNot = 1 then 1 else 0 end),
        TotalInactiveCookbooks = sum(case when cb.ActiveOrNot = 0 then 1 else 0 end)
from Users u 
join Cookbook cb 
on u.UsersId = cb.UsersId
group by u.UserName, cb.ActiveOrNot
--e
select r.RecipeName, DaysUntilArchived = datediff(day,r.DateDrafted,DateArchived)
from Recipe r 
where r.DatePublished is null 
and r.DateArchived is not null 

/*For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
--a
;
with x as(
    select u.FirstName, u.LastName, u.UserName 
    from users u 
    where u.UserName = 'as'
)
select x.UserName,ItemName ='Recipes', Amount = count(r.RecipeId)
    from x 
    join Users u 
    on x.UserName = u.UserName
    join Recipe r 
    on u.UsersId = r.UsersId
    group by x.UserName
union select x.username, 'Meals',count(m.MealId)
    from x 
    join Users u 
    on x.UserName = u.UserName 
    join Meal m 
    on u.UsersId = m.UsersId
    group by x.UserName
union select x.username, 'Cookbooks',count(cb.CookbookId)
    from x 
    join Users u 
    on x.UserName = u.UserName 
    join Cookbook cb 
    on u.UsersId = cb.UsersId
    group by x.UserName
--b
-- SM Tip: Use <> draft.
-- You can use isnull()
select r.RecipeName, u.UserName, HoursTookToGetToStatus = datediff (hour, 
    (case when r.CurrentStatus = 'archived' and r.DatePublished is not null then r.DatePublished else r.DateDrafted end), 
    (case when r.CurrentStatus = 'published' then r.DatePublished else r.DateArchived end))
from users u 
join Recipe r 
on u.UsersId = r.UsersId
where r.CurrentStatus <> 'draft'