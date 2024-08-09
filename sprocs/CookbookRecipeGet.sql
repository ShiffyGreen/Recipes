create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@SequenceNumber int = 0,
	@All int = 0
)
as 
begin
	select CookbookRecipeId,CookbookId,recipeid,sequencenumber
	from cookbookrecipe cr
	--join recipe r 
	--on r.recipeId = cr.recipeid
	where cr.CookbookRecipeId = @cookbookrecipeid
	or @All = 1
	or cr.CookbookId = @CookbookId
end
go
select * from cookbookrecipe
