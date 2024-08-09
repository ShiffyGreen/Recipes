create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)
	begin try 
		begin tran
		delete cbr from CookbookRecipe cbr 
			join Cookbook cb on cbr.CookbookId = cb.CookbookId
			join Users u on cb.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete cb from Cookbook cb 
			join Users u on cb.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete mcr from MealCourseRecipe mcr 
			join MealCourse mc on mcr.MealCourseId = mc.MealCourseId
			join meal m on mc.MealId = m.MealId
			join users u on m.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete mc from MealCourse mc 
			join meal m on mc.MealId = m.MealId
			join users u on m.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete m from meal m 
			join users u on m.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete cbr from Recipe r 
			join CookbookRecipe cbr on r.RecipeId = cbr.RecipeId
			join users u on r.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete ri from Recipe r 
			join RecipeIngredient ri on r.RecipeId = ri.RecipeId
			join Users u on r.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete d from Recipe r 
			join Directions d on r.RecipeId = d.RecipeId
			join Users u on r.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete mcr from Recipe r
			join MealCourseRecipe mcr on r.RecipeId = mcr.RecipeId
			join Users u on r.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete r from Recipe r 
			join Users u on r.UsersId = u.UsersId
			where u.UsersId = @UsersId
		delete u from Users u 
			where u.UsersId = @UsersId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go
