create or alter proc dbo.CookbookListGet(
	@Message varchar(500) = ''
)

as 
begin
	select cb.CookbookId, cb.CookbookName, UserName = concat(u.firstname,' ',u.lastname), NumofRecipes = count(cbr.RecipeId)
	from Cookbook cb 
	left join Users u 
	on cb.UsersId = u.UsersId
	left join CookbookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId
	group by cb.cookbookid,cb.CookbookName, u.firstname,u.lastname
	order by cb.CookbookName
end
go 
exec CookbookListGet
