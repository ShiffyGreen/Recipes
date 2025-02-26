create or alter proc dbo.CookbookListGet(
	@Message varchar(500) = '',
	@All bit = 0,
	@includeblank bit = 0,
	@cookbooklistId int = 0
)

as 
begin
	select cb.CookbookId, cb.CookbookName, UserName = concat(u.firstname,' ',u.lastname), NumofRecipes = count(cbr.RecipeId), cb.skilllevel
	from Cookbook cb 
	join Users u 
	on cb.UsersId = u.UsersId
	join CookbookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId
	group by cb.cookbookid,cb.CookbookName, u.firstname,u.lastname, cb.skilllevel
	order by cb.CookbookName
end
go 
exec CookbookListGet
