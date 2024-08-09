create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)

	begin try 
		begin tran
			delete cr from cookbookrecipe cr join recipe r on r.RecipeId = cr.RecipeId where r.CuisineId = @CuisineId
			delete mcr from MealCourseRecipe mcr join Recipe r on r.RecipeId = mcr.RecipeId where r.CuisineId = @CuisineId
			delete d from Directions d  join Recipe r on r.RecipeId = d.RecipeId where r.CuisineId = @CuisineId
			delete ri from recipeingredient ri join recipe r on r.RecipeId = ri.RecipeId where r.CuisineId = @CuisineId
			delete recipe where CuisineId = @CuisineId
			delete Cuisine where CuisineId = @CuisineId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go
