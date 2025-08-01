use heartyhearthdb
go
create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@cuisineId int = 0
)
as 
begin
	
	select @RecipeName = nullif(@RecipeName,'')

	select r.RecipeId,r.CuisineId,r.UsersId,r.RecipeName,r.CalorieCount,r.DateDrafted,r.DatePublished,r.DateArchived,r.CurrentStatus,r.PictureName,r.vegan
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	or r.cuisineId = @cuisineid
	union select 0,0,0,'',0,'','','','','',0
	where @IncludeBlank = 1
	order by r.RecipeName
end
go

exec RecipeGet

exec RecipeGet @All = 1, @includeblank = 1

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'a'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId

exec RecipeGet @cuisineId = 2