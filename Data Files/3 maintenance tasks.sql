-- SM Excellent! See comment, fix and resubmit.
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.
use HeartyHearthDB
--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete cbr 
from CookbookRecipe cbr 
join Cookbook cb 
on cbr.CookbookId = cb.CookbookId
join Users u 
on cb.UsersId = u.UsersId
where u.UserName = 'as'

delete cb 
from Cookbook cb 
join Users u 
on cb.UsersId = u.UsersId
where u.UserName = 'as'

delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc 
on mcr.MealCourseId = mc.MealCourseId
join meal m 
on mc.MealId = m.MealId
join users u 
on m.UsersId = u.UsersId
where u.UserName = 'as'

delete mc 
from MealCourse mc 
join meal m 
on mc.MealId = m.MealId
join users u 
on m.UsersId = u.UsersId
where u.UserName = 'as'

delete m 
from meal m 
join users u 
on m.UsersId = u.UsersId
where u.UserName = 'as'

delete cbr
from Recipe r 
join CookbookRecipe cbr 
on r.RecipeId = cbr.RecipeId
join users u 
on r.UsersId = u.UsersId
where u.UserName = 'as'

delete ri 
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Users u 
on r.UsersId = u.UsersId
where u.UserName = 'as'

delete d 
from Recipe r 
join Directions d 
on r.RecipeId = d.RecipeId
join Users u 
on r.UsersId = u.UsersId
where u.UserName = 'as'

delete mcr 
from Recipe r
join MealCourseRecipe mcr 
on r.RecipeId = mcr.RecipeId
join Users u 
on r.UsersId = u.UsersId
where u.UserName = 'as'

delete r 
from Recipe r 
join Users u 
on r.UsersId = u.UsersId
where u.UserName = 'as'

delete u 
from Users u 
where u.UserName = 'as'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(RecipeName, UsersId, CuisineId, CalorieCount, DateDrafted, DatePublished, DateArchived)
select concat(r.RecipeName,' - clone'),r.UsersId,r.CuisineId, r.CalorieCount,GETDATE(),GETDATE(),null
from recipe r 
where r.RecipeName = 'muddy buddies'

;
with x as(
    select r.recipeid, r.RecipeName
    from recipe r 
    where r.RecipeName = 'muddy buddies - clone'
)
insert RecipeIngredient (RecipeId, IngredientId, UnitOfMeasureId, Amount,IngredientSequence)
select x.RecipeId,ri.IngredientId,ri.UnitOfMeasureId,ri.amount,ri.IngredientSequence
from x
cross join Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'muddy buddies'

;
with x as(
    select r.recipeid, r.RecipeName
    from recipe r 
    where r.RecipeName = 'muddy buddies - clone'
)
insert Directions (RecipeId, Instructions, DirectionsSequence)
select x.RecipeId, d.DirectionsId, d.DirectionsSequence
from x
cross join recipe r
join directions d
on r.RecipeId = d.RecipeId
where r.RecipeName = 'muddy buddies'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
     The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

insert Cookbook(CookbookName,UsersId,Price)
select concat('Recipes by ',u.FirstName,' ',u.LastName),u.UsersId, 1.33 * count(RecipeId) 
from Recipe r 
join users u 
on r.UsersId = u.UsersId
where u.UserName = 'lk'
group by u.FirstName,u.LastName,u.UsersId

;
with x as(
    select CookbookName = concat('Recipes by ',u.FirstName,' ',u.LastName),r.RecipeName, Sequence = ROW_NUMBER() over (order by r.recipename)
    from Recipe r
    join Users u 
    on r.UsersId = u.UsersId
    where u.UserName = 'lk'
)
insert CookbookRecipe(CookbookId,RecipeId,SequenceNumber)
select cb.CookbookId,r.RecipeId,x.Sequence
from x
join Recipe r 
on x.RecipeName = r.RecipeName
join Cookbook cb 
on x.CookbookName = cb.CookbookName

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
;
with x as (
    select CalorieCount = case 
        when u.MeasureName = 'oz' then r.CalorieCount - (2 * ri.Amount)
        when u.MeasureName = 'stick' then r.CalorieCount - (10 * ri.Amount)
        else r.CalorieCount
        end,
        r.RecipeName
    from recipe r
    join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    join Ingredient i
    on ri.IngredientId = i.IngredientId
    join UnitOfMeasure u
    on ri.UnitOfMeasureId = u.UnitOfMeasureId
    where i.IngredientName = 'butter'
)
update r
set r.CalorieCount = x.CalorieCount
from x
join recipe r
on x.RecipeName = r.RecipeName



/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
    User First Name, 
    User Last Name, 
    email address (first initial + lastname@heartyhearth.com),
    Alert: 
        Your recipe [recipe name] is sitting in draft for [X] hours.
        That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
-- SM This returns 100502 for the recipe 1310400 more than avg 45902. In my calculation 100502 is not that much more than 45902.
-- Hint: Something is wrong with one of your datediffs. datediff() needs dates not ints.
with x as(
    select AvgHours = avg(datediff(hour,r.DateDrafted,r.DatePublished))
    from Recipe r 
)
select  u.FirstName, 
        u.LastName, 
        Email = concat(substring(u.FirstName,1,1),u.LastName,'@heartyhearth.com'), 
        Alert = concat('Your recipe ', r.recipename,' is sitting in draft for ',datediff(hour,r.DateDrafted,getdate()),' hours. 
                That is ', datediff(hour,x.AvgHours,datediff(hour,r.DateDrafted,getdate())) ,' hours more than the average ', x.AvgHours ,' hours all other recipes took to be published.') 
from users u 
join recipe r 
on r.usersid = u.usersid
join x 
on x.AvgHours < datediff(hour,r.DateDrafted,getdate())
where r.CurrentStatus = 'Draft'


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ',count(cb.CookbookId),' books for sale, average price is ', convert (decimal (8,2), avg(cb.Price)),'. You can order them all and receive a 25% discount, for a total of ',convert (decimal (10,2), sum(cb.Price) * .75),'.
Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from Cookbook cb
