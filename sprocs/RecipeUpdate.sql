create or alter proc dbo.RecipeUpdate(
	@RecipeId int  output,
	@CuisineId int,
	@UsersId int,
	@RecipeName varchar (50),
	@CalorieCount int ,
	@DateDrafted datetime ,
	@DatePublished datetime ,
	@DateArchived datetime, 
	@message varchar(500) = '' output

)
as
begin
	declare @return int = 0

	if @RecipeId = 0
	begin
		insert Recipe(CuisineId,UsersId,RecipeName,CalorieCount,DateDrafted,DatePublished,DateArchived)
		values (@CuisineId,@UsersId,@RecipeName,@CalorieCount,@DateDrafted,@DatePublished,@DateArchived)
	end

	else
	begin
		update Recipe
		set
			CuisineId = @CuisineId,
			UsersId = @UsersId,
			RecipeName = @RecipeName,
			CalorieCount = @CalorieCount,
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished,
			DateArchived = @DateArchived
		where RecipeId = @RecipeId

	end
	begin
		update Recipe
		set 
			CuisineId = @CuisineId,
			UsersId = @UsersId,
			RecipeName = @RecipeName,
			CalorieCount = @CalorieCount,
			DateDrafted = @DateDrafted,
			DatePublished = @DatePublished,
			DateArchived = @DateArchived
			where RecipeId = @RecipeId
	end


end