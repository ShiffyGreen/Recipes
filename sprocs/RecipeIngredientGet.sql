create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = ISNULL(@RecipeIngredientId,0), @RecipeId = ISNULL(@recipeid,0)

	select ri.Amount ,ri.RecipeIngredientId,ri.RecipeId,ri.IngredientId,ri.UnitOfMeasureId,ri.IngredientSequence 
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.RecipeId = @RecipeId
	order by ri.IngredientSequence

	return @return
end
go
exec RecipeIngredientGet @all = 1
