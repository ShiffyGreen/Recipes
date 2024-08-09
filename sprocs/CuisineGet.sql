create or alter procedure dbo.CuisineGet(
	@CuisineId int = 0, 
	@CuisineType varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
	)
as 
begin
	
	select @CuisineType = nullif(@CuisineType,'')

	select c.cuisineId, c.cuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
	union select 0,''
	where @includeBlank = 1
	order by c.CuisineType
end
go
/*
exec CuisineGet

exec CuisineGet @All = 1, @IncludeBlank = 1

exec CuisineGet @CuisineType = ''

exec CuisineGet @CuisineType = 'a'

declare @CuisineId int
--LB: This select statements returns more than one item. Change this to return one item from the table. Same for all other sprocs
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId
*/