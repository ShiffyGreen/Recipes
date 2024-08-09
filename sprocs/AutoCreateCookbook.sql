create or alter proc dbo.AutoCreateCookbook(
	@UsersId int = 0
)
as 
begin
	
	insert Cookbook(CookbookName,UsersId,Price)
	select concat('Recipes by ',u.FirstName,' ',u.LastName),u.UsersId, 1.33 * count(RecipeId) 
	from Recipe r 
	join users u 
	on r.UsersId = u.UsersId
	where u.usersId = @usersid
	group by u.FirstName,u.LastName,u.UsersId

	;
	with x as(
		select CookbookName = concat('Recipes by ',u.FirstName,' ',u.LastName),r.RecipeName, Sequence = ROW_NUMBER() over (order by r.recipename)
		from Recipe r
		join Users u 
		on r.UsersId = u.UsersId
		where u.usersId = @usersid
	)
	insert CookbookRecipe(CookbookId,RecipeId,SequenceNumber)
	select cb.CookbookId,r.RecipeId,x.Sequence
	from x
	join Recipe r 
	on x.RecipeName = r.RecipeName
	join Cookbook cb 
	on x.CookbookName = cb.CookbookName

end