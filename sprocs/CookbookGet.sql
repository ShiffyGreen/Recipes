create or alter proc CookbookGet(
	@CookbookId int = 0,
	@CookbookName varchar(50) = '',
	@All bit = 0
)
as
begin
	if @All = 1
	begin
		select cb.CookbookId, cb.CookbookName, UserName = concat(u.firstname,' ',u.lastname), NumofRecipes = count(cbr.RecipeId)
		from Cookbook cb 
		join Users u 
		on cb.UsersId = u.UsersId
		Left join CookbookRecipe cbr 
		on cb.CookbookId = cbr.CookbookId
		group by cb.cookbookid,cb.CookbookName, u.firstname,u.lastname
		order by cb.CookbookName
	end
	else 
	begin
		select c.CookbookId,c.UsersId,c.CookbookName,c.Price,c.ActiveOrNot,c.DateCreated 
		from Cookbook c 
		where c.CookbookId = @CookbookId
		or @all = 1
		order by c.CookbookName
	end
end
go 
exec CookbookGet @All = 1


	