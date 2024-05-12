-- SM Excellent! 100%
use HeartyHearthDB
go

delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete Course
delete Directions
delete RecipeIngredient
delete UnitOfMeasure
delete Recipe
delete Users
delete Ingredient
delete Cuisine
go
--cuisine
insert Cuisine (CuisineType)
select 'American'
union select 'French'
union select 'English'
--ingredient
insert Ingredient (IngredientName)
select 'sugar'
union select 'flour'
union select 'oil'
union select 'eggs'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic (crushed)'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'Bagel'
union select 'Marinara sauce'
union select 'Hot cocoa mix'
union select 'Milk'
union select 'Chex'
union select 'Peanut Butter'
union select 'Confectionaries sugar'
--users
insert Users (FirstName, LastName, UserName)
select 'Mimi', 'Friedman', 'mf'
union select 'Avigayil', 'Segal', 'as'
union select 'Leba', 'Kaufman', 'lk'
union select 'Eliana', 'Kramer', 'ek'
--recipe
;
with x as (
 select RecipeName = 'Chocolate Chip Cookies', UserName= 'mf', cuisine = 'American', CalorieCount = 300, DateDrafted = '05-25-04', DatePublished = '01-25-24', DateArchived = null
 union select 'Apple Yogurt Smoothie', 'as', 'French', 75, '06-06-2022', null,'11-7-23'
 union select 'Cheese Bread', 'mf', 'English', 150, '09-24-2012', null, null
 union select 'Butter Muffins', 'as', 'American', 310, '08-25-2014', '08-15-2020',null
 union select 'Pizza Bagels', 'lk','American', 339, '03-26-2015','05-27-2015',null 
 union select 'Hot Cocoa', 'lk', 'English',290, '08-31-2017','01-13-2018','07-03-2022'
 union select 'Muddy Buddies','ek','American', 530, '02-28-2023', null, null
)
insert recipe (RecipeName, UsersId, CuisineId, CalorieCount, DateDrafted, DatePublished, DateArchived)
select x.RecipeName, u.UsersId, c.CuisineId, x.CalorieCount, x.DateDrafted ,x.DatePublished,x.datearchived 
from x
join Cuisine c
on x.cuisine = c.CuisineType
join users u
on x.UserName = u.UserName
--unit of measure
insert UnitOfMeasure(MeasureName)
select 'Cup'
union select 'Tsp'
union select 'Tbsp'
union select 'Oz'
union select 'Pinch'
union select 'Stick'
union select 'Cups'
--recipeingredient
;
with x as (
   select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'sugar', Measurement = 1, MeasurementType = 'cup',ingredientSequence = 1
   union select 'Chocolate Chip Cookies', 'oil', 0.5, 'cup',2
   union select 'Chocolate Chip Cookies', 'eggs', 3, '',3
   union select 'Chocolate Chip Cookies', 'flour', 2, 'cups',4
   union select 'Chocolate Chip Cookies', 'vanilla sugar', 1, 'tsp',5
   union select 'Chocolate Chip Cookies','baking powder', 2, 'tsp',6
   union select 'Chocolate Chip Cookies', 'baking soda', 0.5, 'tsp',7
   union select 'Chocolate Chip Cookies','chocolate chips', 1, 'cup',8
   union select 'Apple Yogurt Smoothie', 'granny smith apples', 3, '',1
   union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 2, 'cups',2
   union select 'Apple Yogurt Smoothie', 'sugar', 2, 'tsp',3
   union select 'Apple Yogurt Smoothie', 'orange juice', 0.5, 'cup',4
   union select 'Apple Yogurt Smoothie', 'honey', 2, 'tbsp',5
   union select 'Apple Yogurt Smoothie', 'ice cubes', 5.5, '',6
   union select 'Cheese Bread', 'club bread', 1, '',1
   union select 'Cheese Bread', 'butter', 4, 'oz',2
   union select 'Cheese Bread', 'shredded cheese', 8, 'oz',3
   union select 'Cheese Bread', 'garlic (crushed)', 2, 'cloves',4
   union select 'Cheese Bread', 'black pepper', 0.5, 'tsp',5
   union select 'Cheese Bread', 'salt', 1, 'pinch',6
   union select 'Butter Muffins', 'butter', 1, 'stick',1
   union select 'Butter Muffins','sugar', 3, 'cups',2
   union select 'Butter Muffins', 'vanilla pudding', 2, 'tbsp',3
   union select 'Butter Muffins', 'eggs', 4, '',4
   union select 'Butter Muffins', 'whipped cream cheese', 8, 'oz',5
   union select 'Butter Muffins', 'sour cream cheese', 8, 'oz',6
   union select 'Butter Muffins', 'flour', 1, 'cup',7
   union select 'Butter Muffins', 'baking powder', 2, 'tsp',8
   union select 'Pizza Bagels', 'bagel', 1,'', 1
   union select 'Pizza Bagels', 'Marinara sauce', 2, 'tsp',2
   union select 'Pizza Bagels', 'Shredded cheese',4, 'oz',3
   union select 'Hot Cocoa', 'Hot cocoa mix', 2, 'tsp',1
   union select 'Hot Cocoa', 'Milk',0.5, 'cup', 2
   union select 'Hot Cocoa', 'Chocolate Chips', 0.25,'cup', 3
   union select 'Muddy Buddies','chex',6,'cups',1
   union select 'Muddy Buddies','Peanut Butter',1,'cup',2
   union select 'Muddy Buddies','Chocolate Chips',1,'cup',3
   union select 'Muddy Buddies','confectionaries sugar',0.75,'cups', 4
   )
insert RecipeIngredient (RecipeId, IngredientId, UnitOfMeasureId, Amount,IngredientSequence)
select r.RecipeId, i.IngredientId,u.UnitOfMeasureId, x.Measurement,x.ingredientSequence
from x
join recipe r
on r.RecipeName = x.RecipeName
join Ingredient i
on i.IngredientName = x.IngredientName
left join UnitOfMeasure u 
on x.MeasurementType = u.Measurename

--directions
;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', Instructions = 'First combine sugar, oil and eggs in a bowl',DirectionsSequence = 1
   union select 'Chocolate Chip Cookies','mix well',2
   union select 'Chocolate Chip Cookies','add flour, vanilla sugar, baking powder and baking soda',3
   union select 'Chocolate Chip Cookies','beat for 5 minutes',4
   union select 'Chocolate Chip Cookies','add chocolate chips',5
   union select 'Chocolate Chip Cookies','freeze for 1-2 hours',6
   union select 'Chocolate Chip Cookies','roll into balls and place spread out on a cookie sheet',7
   union select 'Chocolate Chip Cookies','bake on 350 for 10 min.',8
   union select 'Apple Yogurt Smoothie', 'Peel the apples and dice',1
   union select 'Apple Yogurt Smoothie', 'Combine all ingredients in bowl except for apples and ice cubes',2
   union select 'Apple Yogurt Smoothie', 'mix until smooth',3
   union select 'Apple Yogurt Smoothie', 'add apples and ice cubes',4
   union select 'Apple Yogurt Smoothie', 'pour into glasses.',5 
   union select 'Cheese Bread', 'Slit bread every 3/4 inch',1
   union select 'Cheese Bread', 'Combine all ingredients in bowl',2
   union select 'Cheese Bread', 'fill slits with cheese mixture',3
   union select 'Cheese Bread', 'wrap bread into a foil and bake for 30 minutes.',4
   union select 'Butter Muffins', 'Cream butter with sugars',1
   union select 'Butter Muffins','Add eggs and mix well',2
   union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well',3
   union select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes.',4
   union select 'Pizza Bagels', 'Spread marinara sauce over the bagel',1
   union select 'Pizza Bagels', 'Sprinkle shredded cheese on top',2
   union select 'Pizza Bagels', ' Bake on 425 for 6 minutes.',3
   union select 'Hot Cocoa', 'Heat up the milk',1
   union select 'Hot Cocoa', 'Mix in the hot cocoa mix',2
   union select 'Hot Cocoa', 'add chocolate chips if desired',3
   union select 'Muddy Buddies',' Melt chocolate chips and peanut butter',1
   union select 'Muddy Buddies', 'Pour over the chex',2
   union select 'Muddy Buddies', 'When cooled, cover with confectionaries sugar.',3
)
insert directions(recipeid,Instructions,DirectionsSequence)
select r.recipeid, x.Instructions, x.DirectionsSequence
from x
join recipe r 
on x.RecipeName = r.recipename
--course
insert course (CourseName,coursesequence)
select 'appetizer',1
union select 'main course',2
union select 'dessert',3
--meal
;
with x as (
   select MealName = 'breakfast bash', UserName = 'mf', ActiveOrNot = 1
   union select 'brunch', 'ek', 1
   union select 'midnight snack', 'as', 0
   union select 'party time', 'ek', 1
)
insert Meal (MealName, UsersId, ActiveOrNot)
select x.MealName, u.UsersId, x.ActiveOrNot
from x
join users u
on x.UserName = u.UserName
--mealcourse
;
with x as (
   select MealName = 'breakfast bash', CourseName = 'appetizer'
   union select 'breakfast bash', 'main course'
   union select 'brunch', 'appetizer'
   union select 'brunch', 'main course'
   union select 'brunch', 'dessert'
   union select 'midnight snack', 'main course'
   union select 'midnight snack', 'dessert'
   union select 'party time', 'appetizer'
   union select 'party time', 'main course'
   union select 'party time', 'dessert'
)
insert MealCourse (MealId, CourseId)
select m.MealId, c.CourseId
from x
join meal m
on x.MealName = m.MealName
join course c 
on x.CourseName = c.CourseName

--mealcourserecipe
;
with x as(
   select MealName = 'breakfast bash', CourseName = 'appetizer', Recipename = 'Apple Yogurt Smoothie', MainOrSideDish = ''
   union select 'breakfast bash', 'main course', 'Cheese Bread',1
   union select 'breakfast bash', 'main course', 'Butter Muffins',0
   union select 'brunch', 'appetizer','Butter Muffins',''
   union select 'brunch', 'main course','Pizza Bagels',''
   union select 'brunch', 'dessert','Muddy Buddies',''
   union select 'midnight snack', 'main course','Chocolate Chip Cookies',1
   union select 'midnight snack', 'main course','Hot Cocoa',0
   union select 'party time', 'appetizer','Muddy Buddies',''
   union select 'party time', 'main course','Chocolate Chip Cookies',''
   union select 'party time', 'dessert','Hot Cocoa',''
)
insert MealCourseRecipe (MealCourseId, RecipeId,ismaindish)
select mc.MealCourseId,r.RecipeId,x.MainOrSideDish
from x 
join recipe r 
on x.Recipename = r.RecipeName
join Meal m 
on x.MealName = m.MealName
join course c 
on x.CourseName = c.CourseName
join MealCourse mc 
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId



--cookbook
;
with x as(
   select cookbookname = 'Treats for two', UserName = 'lk',Price = 30,activeornot = 'true'
   union select 'Cooking Hacks', 'as',25,'false'
   union select 'Sweet Eats','mf',35,'true'
   union select 'A Taste Of Heaven', 'as',24,'true'
)
insert Cookbook(CookbookName,UsersId,Price,ActiveOrNot)
select x.cookbookname,u.UsersId,x.Price,x.activeornot
from x 
join Users u 
on x.UserName = u.UserName

--cookbookrecipe
;
with x as(
   select cookbookname = 'Treats for two', RecipeName = 'Chocolate Chip Cookies', SequenceNumber = 1
   union select  'Treats for two',  'Apple Yogurt Smoothie', 2
   union select  'Treats for two',  'Cheese Bread', 3
   union select 'Treats for two',  'Butter Muffins', 4
   union select 'Cooking Hacks',  'Muddy Buddies', 1
   union select 'Cooking Hacks',  'Pizza Bagels', 2
   union select 'Cooking Hacks',  'Cheese Bread', 3
   union select 'Cooking Hacks',  'Hot Cocoa', 4
   union select 'Sweet Eats',  'Butter Muffins', 1
   union select 'Sweet Eats',  'Chocolate Chip Cookies', 2
   union select 'Sweet Eats',  'Hot Cocoa', 3
   union select 'Sweet Eats',  'Muddy Buddies', 4
   union select 'A Taste Of Heaven',  'Apple Yogurt Smoothie', 1
   union select 'A Taste Of Heaven',  'Butter Muffins', 2
   union select 'A Taste Of Heaven',  'Pizza Bagels', 3
   union select 'A Taste Of Heaven',  'Hot Cocoa', 4
)
insert CookbookRecipe(CookbookId,RecipeId,SequenceNumber)
select cb.CookbookId,r.RecipeId,x.SequenceNumber
from x 
join Cookbook cb 
on x.cookbookname = cb.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName
 
