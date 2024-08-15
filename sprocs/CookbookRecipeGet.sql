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
	where cr.CookbookRecipeId = @cookbookrecipeid
	or @All = 1
	or cr.CookbookId = @CookbookId
	order by cr.SequenceNumber
end
go
select * from cookbookrecipe
