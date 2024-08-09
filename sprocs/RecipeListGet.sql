create or alter proc dbo.RecipeListGet(
	@RecipeId int = 0,
	@All int = 0,
	@IncludeBlank bit = 0,
)
as 
begin 
	select @RecipeId = isnull(@RecipeId,0)

	select r.RecipeId, r.RecipeName, r.CurrentStatus, UserName = concat(u.FirstName,' ',u.LastName), r.CalorieCount, NumIngredients = count(ri.ingredientId) 
	from Recipe r 
	left join Users u 
	on r.UsersId = u.UsersId
	left join RecipeIngredient ri 
	on ri.RecipeId = r.recipeid
	where r.RecipeId = @recipeid
	or @all = 1
	group by r.recipeid, r.RecipeName, r.CurrentStatus, r.CalorieCount, u.FirstName, u.LastName
	order by r.CurrentStatus desc
	
end

go 
exec RecipeListGet @All = 1