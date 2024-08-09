create or alter proc dbo.CookbookListGet(
	@Message varchar(500) = ''
)

as 
begin
	select cb.CookbookId, cb.CookbookName, u.UserName, NumofRecipes = count(cbr.RecipeId)
	from Cookbook cb 
	join Users u 
	on cb.UsersId = u.UsersId
	join CookbookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId
	group by cb.cookbookid,cb.CookbookName, u.UserName
	order by cb.CookbookName
end
go 
exec CookbookListGet
