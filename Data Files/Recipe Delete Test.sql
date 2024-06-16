declare @recipeid int 

select top 1 @recipeid = r.RecipeId
from Recipe r 
left join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
left join Directions d 
on r.RecipeId = d.RecipeId
where ri.RecipeIngredientId is null 
and d.DirectionsId is null

select * from Recipe r where r.RecipeId = @recipeid

exec RecipeDelete @recipeid = @recipeid

select * from Recipe r where r.RecipeId = @recipeid


select * from Recipe where RecipeName = 'test'
