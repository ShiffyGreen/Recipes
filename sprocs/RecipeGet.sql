create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(50) = '', @All bit = 0)
as 
begin
	
	select @RecipeName = nullif(@RecipeName,'')

	select r.RecipeId,r.CuisineId,r.UsersId,r.RecipeName,r.CalorieCount,r.DateDrafted,r.DatePublished,r.DateArchived,r.CurrentStatus,r.PictureName
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	order by r.RecipeName
end
go

exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'a'

declare @RecipeId int
select @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId