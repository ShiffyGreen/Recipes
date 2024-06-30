declare @recipeid int 

select top 1 @recipeid = r.RecipeId
from Recipe r 
left join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
left join Directions d 
on r.RecipeId = d.RecipeId
where ri.RecipeIngredientId is null 
and d.DirectionsId is null
and (r.CurrentStatus = 'draft' or datediff(day,r.datearchived,getdate()) >= 30)

select 'Recipe',r.RecipeId,r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'Recipe Ingredient',ri.RecipeIngredientId,i.IngredientName from RecipeIngredient ri join Ingredient i on ri.ingredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'directions', d.DirectionsId,d.Instructions from Directions d where d.RecipeId = @recipeid

declare @return int, @message varchar(500)

exec @return = RecipeDelete @recipeid = @recipeid, @message = @message output

select @return, @message

select 'Recipe',r.RecipeId,r.RecipeName from Recipe r where r.RecipeId = @recipeid
union select 'Recipe Ingredient',ri.RecipeIngredientId,i.IngredientName from RecipeIngredient ri join Ingredient i on ri.ingredientId = i.IngredientId where ri.RecipeId = @recipeid
union select 'directions', d.DirectionsId,d.Instructions from Directions d where d.RecipeId = @recipeid


