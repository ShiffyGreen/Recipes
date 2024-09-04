use heartyhearthdb
go
create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0
)
as 
begin

	select @RecipeName = nullif(@RecipeName,'')

	if @All = 1 
	begin
			select r.RecipeId, r.RecipeName, r.CurrentStatus, UserName = concat(u.FirstName,' ',u.LastName), r.CalorieCount, NumIngredients = count(ri.ingredientId) 
		from Recipe r 
		left join Users u 
		on r.UsersId = u.UsersId
		left join RecipeIngredient ri 
		on ri.RecipeId = r.recipeid
		where r.RecipeId = @recipeid
		or @all = 1
		group by r.recipeid, r.RecipeName, r.CurrentStatus, r.CalorieCount, u.FirstName, u.LastName
		order by r.CurrentStatus desc
	end

	else 
	begin
		select r.RecipeId,r.CuisineId,r.UsersId,r.RecipeName,r.CalorieCount,r.DateDrafted,r.DatePublished,r.DateArchived,r.CurrentStatus,r.PictureName
		from Recipe r
		where r.RecipeId = @RecipeId
		or @All = 1
		or r.RecipeName like '%' + @RecipeName + '%'
		union select 0,0,0,'',0,'','','','',''
		where @IncludeBlank = 1
		order by r.RecipeName
	end
end
go

exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'a'

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId