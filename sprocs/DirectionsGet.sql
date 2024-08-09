create or alter procedure dbo.DirectionsGet(
	@DirectionsId int = 0,
	@RecipeId int = 0,
	@Instructions varchar(50) = '', 
	@DirectionSequence int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
	)
as 
begin
	declare @return int = 0
	select @DirectionsId = isnull(@directionsid,0), @RecipeId = isnull(@RecipeId,0), @Instructions = isnull(@Instructions,''), @DirectionSequence = ISNULL(@DirectionSequence,0)

	select d.DirectionsId,d.RecipeId,d.Instructions,d.DirectionsSequence
	from Directions d  
	where d.DirectionsId = @DirectionsId
	or @All = 1
	or d.RecipeId = @RecipeId
	union select 0,0,'',0
	where @IncludeBlank = 1
	order by d.directionsSequence

	return @return
end
go

exec DirectionsGet @all = 1, @includeblank = 1