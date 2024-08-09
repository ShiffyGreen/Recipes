create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@SequenceNumber int = 0
)
as
begin
	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId,RecipeId,SequenceNumber)
		values(@CookbookId,@RecipeId,@SequenceNumber)

		select @CookbookRecipeId = scope_identity()
	end

	else
	begin
		update CookbookRecipe
		set CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			SequenceNumber = @SequenceNumber
		where CookbookRecipeId = @CookbookRecipeId
	end
end
go