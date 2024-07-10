create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(150)
as
begin 
	declare @value varchar(150)

	select @value = concat(r.RecipeName,' (',c.CuisineType,') has ',
	(select count(*) from RecipeIngredient ri where ri.RecipeId = r.RecipeId),' ingredients and ',
	(select count(*) from Directions d where d.RecipeId = r.RecipeId),' steps.')
	from Recipe r 
	join Cuisine c 
	on c.CuisineId = r.CuisineId
	where r.RecipeId = @RecipeId

	return @value
end
go 

select RecipeDesc = dbo.RecipeDesc(r.recipeId)
from Recipe r

