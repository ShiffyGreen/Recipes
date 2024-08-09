create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@UnitofMeasureId int = 0,
	@IngredientSequence int = 0,
	@Amount decimal(4,2)
)
as 
begin
	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId,IngredientId,UnitOfMeasureId,IngredientSequence,Amount)
		values(@RecipeId,@IngredientId,@UnitofMeasureId,@IngredientSequence,@Amount)

		select @RecipeIngredientId = SCOPE_IDENTITY()
	end

	else 
	begin
		update RecipeIngredient
		set RecipeId = @RecipeId,
			IngredientId = @IngredientId,
			UnitOfMeasureId = @UnitofMeasureId,
			IngredientSequence = @IngredientSequence,
			Amount = @Amount
		where RecipeIngredientId = @RecipeIngredientId
	end

end
go 

exec recipeingredientupdate

select * 
from Recipe r 
join RecipeIngredient ri 
on r.recipeid = ri.recipeid



select * from recipeingredient