--alter table recipe add Vegan bit not null default ''
--alter table meal add description  varchar(500) not null default ''
--alter table cookbook add skilllevel varchar(15) not null default ''

--;
--with x as(
--	select 'Apple Yogurt Smoothie' as recipename, 1 as vegan
--	union select 'Butter Muffins' as recipename, 1 as vegan
--	union select 'Cheese Bread' as recipename, 1 as vegan
--	union select 'Chocolate Chip Cookies' as recipename, 1 as vegan
--	union select 'Hot Cocoa' as recipename, 1 as vegan
--	union select 'Muddy Buddies' as recipename, 1 as vegan
--	union select 'Pizza Bagels' as recipename, 1 as vegan
--	union select 'Chocolate Cakes' as recipename, 1 as vegan
--	union select 'Potato Kugel' as recipename, 1 as vegan
--	union select 'test' as recipename, 0 as vegan
--)
--UPDATE r
--SET r.vegan = x.vegan
--FROM Recipe r 
--join x ON r.RecipeName = x.recipename
--; with x as (
--	select 'breakfast bash' as mealname, 'The most magnificant breakfast you ever tasted' as description
--	union select 'brunch' as mealname, 'The most filling brunch you can have' as description
--	union select 'midnight snack' as mealname, 'The best snacks you can think of' as description
--	union select 'party time' as mealname, 'Anything you can think of for a party' as description
--)
--update m 
--set m.description = x.description
--from Meal m
--join x on m.MealName = x.mealname

; with x as (
	select 'A Taste Of Heaven' as cookbookname, 'advanced' as skilllevel
	union select 'Cooking Hacks' as cookbookname, 'beginner' as skilllevel
	union select 'Sweet Eats' as cookbookname, 'intermediate' as skilllevel
	union select 'Treats for two' as cookbookname, 'intermediate' as skilllevel
)
update c 
set c.skilllevel = x.skilllevel
from Cookbook c
join x on c.CookbookName = x.cookbookname


select * from Cookbook