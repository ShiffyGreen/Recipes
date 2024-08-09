create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0, 
	@IngredientName varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as 
begin
	declare @return int = 0
	select @IngredientName = nullif(@ingredientname,'')

	select i.IngredientId,i.IngredientName
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	or i.IngredientName like '%' + @IngredientName + '%'
	union select 0,''
	where @IncludeBlank = 1
	order by i.IngredientName

	return @return
end
go

exec IngredientGet @all = 1, @includeblank = 1