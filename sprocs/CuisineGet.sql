create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @CuisineType varchar(50) = '', @All bit = 0)
as 
begin
	
	select @CuisineType = nullif(@CuisineType,'')

	select *
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
	order by c.CuisineType
end
go

exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = ''

exec CuisineGet @CuisineType = 'a'

declare @CuisineId int
--LB: This select statements returns more than one item. Change this to return one item from the table. Same for all other sprocs
select @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId