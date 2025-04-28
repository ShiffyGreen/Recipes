create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@SequenceNumber int = 0,
	@All int = 0,
	@IncludeBlank bit = 0
)
as 
begin
	select CookbookRecipeId,CookbookId,cr.recipeid,r.RecipeName,sequencenumber,r.caloriecount,r.vegan,r.datepublished
	from cookbookrecipe cr
	join Recipe r on r.RecipeId = cr.RecipeId
	where cr.CookbookRecipeId = @cookbookrecipeid
	or @All = 1
	or cr.CookbookId = @CookbookId
	order by cr.SequenceNumber
end
go
exec CookbookRecipeGet @cookbookid = 1

