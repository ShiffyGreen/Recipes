use HeartyHearthDB
go 
create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	if exists(select * from recipe r where r.RecipeId = @RecipeId and (r.CurrentStatus = 'published' or datediff(day,r.datearchived,getdate()) <= 30))
	begin 
		select @return = 1, @Message = 'Cannot delete recipe that has been published and is not archived for more then 30 days.'
		goto finished
	end
	begin try
		begin tran
		delete cookbookrecipe where recipeid = @recipeid
		delete mealcourserecipe where recipeid = @recipeid
		delete Directions where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go


